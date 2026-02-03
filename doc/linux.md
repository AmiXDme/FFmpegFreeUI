# General Methods for Using FFmpegFreeUI on Linux Systems

> This content is mainly provided by [Uyanide](https://github.com/Uyanide)

## Prerequisites

- **A working Wine**: Since FFmpegFreeUI uses the WinForms UI framework, which is not cross-platform, it needs to run through a compatibility layer on Linux. This means you need to configure [Wine](https://www.winehq.org) or other compatibility environments based on it, such as [Proton](https://steamcommunity.com/games/221410/announcements/detail/1696055855739350561). Configuration methods for such software vary by distribution and are not discussed here. You can refer to:

    - [Wine Wiki](https://gitlab.winehq.org/wine/wine/-/wikis/home)
    - [Wine - ArchWiki](https://wiki.archlinux.org/title/Wine)
    - [Steam - ArchWiki](https://wiki.archlinux.org/title/Steam)

> [!TIP]
> If you plan to call the Linux version of ffmpeg natively instead of the translated ffmpeg.exe, it is recommended to use the original version of Wine for the best support. Other compatibility layers such as Proton or Wine Staging may encounter various issues. Additionally, we strongly recommend that you understand the basics of Wine, such as the role of WINEPREFIX, before continuing.

> [!TIP]
> We provide a [one-click script](#one-click-script) for you to easily configure the translation environment for calling native ffmpeg. This will automatically handle a series of issues such as fonts / scripts / WINEPREFIX without you needing to worry too much.

- **Patience and Tolerance**: Using a compatibility layer usually means you may encounter various issues in different scenarios, some are operational errors, and some are system bugs. This document cannot cover all possible problems, so sufficient patience and strong tolerance are also important prerequisites :)

## Simple Usage Methods

If you have no special requirements, you can run FFmpegFreeUI and the Windows version of ffmpeg.exe together in the compatibility layer. While slightly "unattractive", it is indeed the most worry-free solution.

The specific steps are simple:

1. Download the Windows version of [ffmpeg distribution](https://www.gyan.dev/ffmpeg/builds/);
2. Place `ffmpeg.exe` and `ffprobe.exe` in the same directory as `FFmpegFreeUI.exe`;
3. Launch `FFmpegFreeUI.exe` using the compatibility layer.

Alternatively, if you wish to keep the Windows version of ffmpeg in another specific directory, you can enter the full [DOS path](https://learn.microsoft.com/en-us/dotnet/standard/io/file-path-formats#traditional-dos-paths) of ffmpeg.exe (e.g., `Z:\home\username\Downloads\ffmpeg-win\ffmpeg.exe`) or a relative path in the `Settings` -> `Alternative Process FileName` setting item in FFmpegFreeUI.

For information on how to obtain the DOS path corresponding to a file under a Unix file system in Wine, please refer to [Path Conversion in Wine](#path-conversion-in-wine).

## Calling Native FFmpeg

### Complete Solution

> [!WARNING]
> The remaining content in this section has only been tested in the Wine environment and does not guarantee availability in other compatibility layers such as Steam's Proton Experimental / Proton Hotfix or Wine Staging.

1. First, prepare three scripts:

   - `wait-exit.bat`: The outermost script exposed to FFmpegFreeUI, used to call `run-ffmpeg.py`, wait for the ffmpeg process to end, and forward its logs:

        ```bat
        @echo off
        setlocal enabledelayedexpansion

        set "log_file=Z:\tmp\3fui_ffmpeg.log"
        set "ret_file=Z:\tmp\3fui_ffmpeg.ret"
        set "finish_sign=Z:\tmp\3fui_ffmpeg_finish"
        set "log_file_tail=Z:\tmp\3fui_ffmpeg.log.tail"

        del "%log_file%"
        del "%ret_file%"
        del "%finish_sign%"
        del "%log_file_tail%"

        set "delay_script=%1"
        shift
        set "run-ffmpeg=%1"

        set "args="
        :loop
        shift
        if "%~1"=="" goto after_args
        set args=!args! "%~1"
        goto loop
        :after_args
        REM

        start "" %run-ffmpeg% %args%

        :check
        if exist "%finish_sign%" (
            set /p ret=<"%ret_file%"
            if not defined ret (
                set ret=1
            )
            type "%log_file%" 1>&2
            exit /b !ret!
        ) else (
            if exist "%log_file_tail%" (
                type "%log_file_tail%" 1>&2
            )
            cscript %delay_script% 2>nul
            goto check
        )

        endlocal
        ```

   - `run-ffmpeg.py`: The script that actually calls ffmpeg, redirecting its logs to a file:

      ```python
      #!/bin/env python3

      import sys
      import subprocess

      LOG_FILE = "/tmp/3fui_ffmpeg.log"
      LOG_TAIL_FILE = "/tmp/3fui_ffmpeg.log.tail"
      RET_FILE = "/tmp/3fui_ffmpeg.ret"
      FINISH_SIGN = "/tmp/3fui_ffmpeg_finish"


      def main():
          try:
              ffmpeg_cmd = ['ffmpeg'] + sys.argv[1:]

              with open(LOG_FILE, 'w') as log_file, open(LOG_TAIL_FILE, 'w') as tail_file:
                  process = subprocess.Popen(
                      ffmpeg_cmd,
                      stderr=subprocess.PIPE,
                      stdout=subprocess.DEVNULL,
                      text=True,
                      bufsize=1
                  )
                  if not process or not process.stderr:
                      return

                  for line in process.stderr:
                      tail_file.seek(0)
                      tail_file.write(line)
                      tail_file.truncate()
                      tail_file.flush()

                      log_file.write(line)
                      log_file.flush()

                  return_code = process.wait()

                  with open(RET_FILE, 'w') as ret_file:
                      ret_file.write(str(return_code) + '\n')

          except Exception as e:
              with open(RET_FILE, 'w') as ret_file:
                  ret_file.write("1\n")

          finally:
              with open(FINISH_SIGN, 'w') as f:
                  f.write("")


      if __name__ == "__main__":
          main()
      ```

   - `delay.vbs`: A tool script used to implement a delay in `wait-exit.bat`:

      ```vb
      WScript.Sleep 1000
      ```

2. Then, enter the full [DOS path](https://learn.microsoft.com/en-us/dotnet/standard/io/file-path-formats#traditional-dos-paths) or relative path of `wait-exit.bat` in the `Settings` -> `Alternative Process FileName` setting item (quotes optional). For example:

    `"Z:\path\to\wait-exit.bat"`

3. In the `Settings` -> `Override Parameter Passing` setting item, sequentially enter the full [DOS path](https://learn.microsoft.com/en-us/dotnet/standard/io/file-path-formats#traditional-dos-paths) or relative path of `delay.vbs` and `run-ffmpeg.py` (quotes optional) and `<args>`, separated by spaces. For example:

    `"Z:\path\to\delay.vbs" "Z:\path\to\run-ffmpeg.py" <args>`

4. Finally, check `Settings` -> `Translation Mode`, and you can normally add files for encoding.

> [!TIP]
> The above scripts and settings have been integrated into the [One-Click Script](#one-click-script), allowing for one-click configuration and startup.

### Alternative Solution

The three scripts above implement basic progress updates and error reporting. If you do not care about these features and only use FFmpegFreeUI as a parameter generator, you can simply check the `Settings` -> `Translation Mode` option, ignore software error messages after starting a task, click `Copy Command Line` on the `Encoding Queue` screen, and run it in the terminal yourself.

Alternatively, if you do not care about progress or error messages but simply want FFmpegFreeUI to start native ffmpeg, you can do the following:

> [!WARNING]
> The remaining content in this section has only been tested in the Wine environment and does not guarantee availability in other compatibility layers such as Steam's Proton Experimental / Proton Hotfix or Wine Staging.

1. Enter `start` in the `Settings` -> `Alternative Process FileName` setting item;
2. Enter `/unix /path/to/ffmpeg <args>` in the `Settings` -> `Override Parameter Passing` setting item, replacing `/path/to/ffmpeg` with the full Unix path of the ffmpeg executable you want to use, such as `/usr/bin/ffmpeg`;
3. Check `Settings` -> `Translation Mode`.

At this point, if you start an encoding task, the corresponding task will show "Error", and ffmpeg will continue running in the background until the task is complete. ffmpeg's stderr output will be visible in the terminal where wine was started.

> Why not use the start /wait parameter? Because it has no effect on the started ffmpeg process :)

## One-Click Script

The [3fui-linux-scripts](https://github.com/MoYingJi/3fui-linux-scripts) project provides a one-click run script.

This project includes the scripts and settings required to call native ffmpeg, and can also install Chinese fonts with one click to solve the issue of square character garbage.

## Other Issues

### Garbage Characters in UI

FFmpegFreeUI provides font setting options. Currently, this setting is located in `Settings` -> `Global Font`. Choosing a font that supports Chinese display and confirming it can solve this problem.

Alternatively, if you cannot find this setting item or wish to configure the correct font before the first launch, you can create a new `Settings.json` file in the same directory as `FFmpegFreeUI.exe` and write the following content:

```json
{
  "Font": "some font"
}
```

Replace `some font` with a Chinese font installed on your system.

> [!TIP]
> If you don't know what fonts are on your system, you can check with `fc-list : family`.

After setting the font in FFmpegFreeUI, you may still find garbage characters in various expected locations. You can try the following solutions (choose one):

- Install fakechinese via [winetricks](https://github.com/Winetricks/winetricks);
- Place the Microsoft YaHei font `msyh.ttc` in the `C:\windows\Fonts\` folder in the same WINEPREFIX as the FFmpegFreeUI runtime.
- Place your favorite Chinese font file in the `C:\windows\Fonts\` folder in the same WINEPREFIX as the FFmpegFreeUI runtime, and manually modify the registry to disguise the Chinese font (reference the approach in [this script](https://github.com/MoYingJi/3fui-linux-scripts/blob/main/prepare.sh)).

### Interface Too Small on High-Resolution Screens

1. Set the environment variable `$WINEPREFIX` to the same WINEPREFIX as the FFmpegFreeUI runtime, and open the Wine configuration interface through `winecfg`.

2. Select "Graphics" in the popup interface and adjust the DPI in "Screen resolution". 144 is recommended for high resolution.

### Path Conversion in Wine

> [!IMPORTANT]
> All the following operations must maintain the same `$WINEPREFIX` as the FFmpegFreeUI runtime. If you don't understand what this is, ignore it; the default is `$HOME/.wine`.

- In general, you can use `winepath -w /unix/path` to convert a Unix path to a DOS path, and `winepath -u Z:\dos\path` to convert a DOS path to a Unix path;

- Alternatively, you can see all drive letter mappings under the `Drivers` tab of `winecfg`;

- Alternatively, you can check the symbolic links under `$WINEPREFIX/dosdevices` to confirm drive letter mapping locations. For example, the result of `ls -l $WINEPREFIX/dosdevices` might be as follows:

  ```
  lrwxrwxrwx 1 username username 10 Jan 01 00:00 c: -> ../drive_c
  lrwxrwxrwx 1 username username  1 Jan 01 00:00 z: -> /
  ...
  ```

  This means `C:\` maps to `$WINEPREFIX/drive_c/` and `Z:\` maps to `/`.

> [!TIP]
> In general, Wine will map `Z:\` to the system root directory `/`. Additionally, Proton usually maps `X:\` to the user's home directory `/home/username/`. However, this is only an empirical rule, and it is recommended to confirm yourself based on the above methods in actual application scenarios.

### Why doesn't XXX work / Why is there an XXX error / Why ...

As stated at the beginning:

> Using a compatibility layer usually means you may encounter various issues in different scenarios, some are operational errors, and some are system bugs. This document cannot cover all possible problems, so sufficient patience and strong tolerance are also important prerequisites :)

Continuous Troubleshooting is an unavoidable part of using GNU/Linux systems, especially for the scenario of forcibly compatible running WinForms applications and calling external binaries as described in this article. Of course, any problems encountered or any suggestions for improvement are welcome, and you are also welcome to join the group for discussion.
