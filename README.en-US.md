

Official Website https://ffmpegfreeui.top and https://3fui.top<br>
Main Group [1050613952](https://qm.qq.com/q/fiauAsddG8) Sub-group ① [1070953324](https://qm.qq.com/q/nKoapm6KyW) Channel [3fui10590000](https://pd.qq.com/s/9emex878m?b=5) KOOK [稻草的工坊](https://kook.vip/1nLQNk)

![](https://img.shields.io/github/stars/Lake1059/FFmpegFreeUI?label=Stargazers) ![GitHub License](https://img.shields.io/github/license/Lake1059/FFmpegFreeUI?label=License) ![GitHub repo size](https://img.shields.io/github/repo-size/Lake1059/FFmpegFreeUI?label=Repo+Size) ![](https://img.shields.io/github/downloads/Lake1059/FFmpegFreeUI/total?label=Github+Total+Downloads) ![](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2F3fui.top%2Fapi%2Fgithub-downloads&label=Mirror+Site+Total+Downloads&query=$.totalDownloads)

<img src="FFmpegFreeUI\Resources\AppIcon.png" width="100" />

## FFmpegFreeUI

FFmpegFreeUI (abbreviated as 3FUI) is a professional interactive wrapper for [FFmpeg](https://ffmpeg.org) on Windows. It is currently developed using the pure WinForms framework with the .NET 10 runtime, featuring a professional and efficient dark-themed UI built with [SunnyUI](https://github.com/yhuse/SunnyUI) and custom drawing. Its goal is to create a transcoding tool for light professional parameter adjustment, allowing ordinary users to access comprehensive general parameters through a GUI to easily encode and convert formats. Not only that, 3FUI offers extremely high freedom and extensibility, making it suitable for deep professionals as well, even if they just want a lightweight progress bar.

It currently includes 40+ video encoders (covering all hardware acceleration from the major vendors), 20+ audio encoders, and 10+ image encoders. If that's not enough, you can customize parameters and provide self-written arguments in various forms, so don't ask "can it do X" or "does it have Y". If my design helps you, please help promote it or consider financial support. Currently, this project is solely sustained by my living expenses, so please don't complain about slow updates.

Bilibili promo video: https://www.bilibili.com/video/BV1eeH9zLED5  
Zhihu tutorial by 终末诗: https://zhuanlan.zhihu.com/p/1943079795341623993

> **Thanks to all bloggers who spontaneously promoted it**
>
> 小in分享 [BV1uzv6BQE2C](https://www.bilibili.com/video/BV1uzv6BQE2C)

<img src="IMG\img1.png"  />

## Development Purpose

Yeah, aren't there plenty of ready-made tools on the market? Remember, 3FUI was born out of frustration. If not for the operational practices of a certain "box" (software), 3FUI wouldn't exist. Is it really hard to want a wrapper with truly transparent, pure, free, and batch-capable parameters? What can I say, it's genuinely TMD hard. This meets the needs of a group of encoders, not the needs of casual converters, nor tools with all sorts of restrictions. I know "Bo Luo" and "Cha Na" are popular, but I'm a perfectionist who wants it all, and I don't do private secret recipes either. Someone might say, "Why not just write batch scripts?" Go tell that to the 25,000 tasks from group members. A wrapper isn't just about stitching parameters; peripheral support is crucial.

## Design Positioning

> [!IMPORTANT]  
>
> TL;DR:
>
> - 3FUI Target Audience: Tinkerers, quality pursuers, perfectionists, professionals, encoders
> - 3FUI Not Suitable For: Those wanting brainless automation, who don't want to read, and don't want to learn anything

3FUI sits at the same table as [HandBrake](https://github.com/HandBrake/HandBrake) and [ShanaEncoder](https://shana.pe.kr/shanaencoder_portable), belonging to the conventional professional-grade encoding/conversion software category. Although **终末诗** rated it as more professional than "Bo Luo" and "Cha Na", I personally see them at the same level. Unlike "Bo Luo" and "Cha Na", 3FUI only uses ffmpeg to execute tasks and does not bundle any codecs. Users must manually place ffmpeg or add it to the environment variables. This keeps 3FUI's performance always up-to-date and removes the need for frequent parameter updates. When ffmpeg updates, you can just swap it in without waiting for anything.

**3FUI is the only wrapper on the market that completely does not include ready-made presets.** It only helps you pass parameters and manage tasks. You must learn the concepts; none can be skipped. Since you're using 3FUI, you must know what you need and understand basic parameter concepts. You can't even tell the difference between container formats and codec formats, right? If it feels unfamiliar, it's because 3FUI emphasizes being straightforward. If you've been misled by amateur explanations from other tools, you'll see the truth here. In 3FUI's parameter interaction design, I fully considered the meaning of every common parameter and categorized the UI accordingly, which will differ significantly from other software.

Do you know how to use "Xiao Wan, Bo Luo, Cha Na, and Format Factory"? Then you already know how to use 3FUI. The underlying logic and basic parameters of all transcoding software are the same. No one can invent a concept from scratch; they all use ffmpeg internally, the ancient god governing audio and video encoding.

## Features

- Fully free transcoding, free combination, arbitrary custom parameters
- Professional interaction design, clear hierarchy, concise and efficient
- Completely ad-free, all productivity features are free
- Ultra-high scaling support with manual fine-tuning calibration
- Preset-based underlying logic for easy scheme sharing
- Most places directly show parameter names, easier to learn and try new schemes
- Real-time ETA calculation, estimated final size, pauseable tasks
- Designed for batch processing, unlimited task addition
- Does not write software info into output files
- No registry touches, no junk files, collects zero information
- Full color management options
- Extensive options for burning subtitles
- Convenient for calling AviSynth and VapourSynth
- Includes simple muxing and merging
- Includes lightweight performance monitoring, counters and gauges
- Includes ffprobe and ffplay calls
- Supports external and remote calls
- Supports plugins

## Supporter Plan

To maintain 3FUI's "Free" status and sustain updates and future projects, starting from version 3.0, a one-time purchase **[Supporter Pack](https://afdian.com/item/a98d04e8b98011f0a49952540025c377)** is offered, providing only personalized features. If you can afford it, your support is welcome. As a paying supporter, you can provide me with your supporter info, which will be hardcoded into 3FUI in the next update.

## Multi-language Support

3FUI now supports multiple languages, but there is still a lot of work to do. The English version is only 10% complete. If you are willing to spontaneously add more languages in the future, please provide proof that your team can guarantee translation quality. I do not want to see negative reviews caused by translation group issues.

## Linux & macOS

[Wine](https://www.winehq.org) is a compatibility layer that runs Windows applications on various POSIX-compliant operating systems. If you can install and use it correctly on macOS and Linux, you can theoretically use 3FUI directly on these systems. Please discuss this part in the group with other members; I can't afford an Apple computer and don't use Linux. Or reportedly, adding it directly to Steam might also make it run?

Contributed by group members: How to use Wine to run 3FUI on Linux: [linux.md](doc/linux.md)

## Download Instructions

| Build Name      | Runtime | Startup Performance | Runtime Performance | File Count | Single-file Execution    | Size |
| ------------- | ------ | -------- | -------- | -------- | ------------- | ---- |
| ReadyToRun    | Bundled   | Relatively slow   | Theoretically best | A few     | Yes (Main exe only) | Medium |
| SelfContained | Bundled | Normal     | Normal     | A bunch     | No          | Largest |
| SingleFile    | Not included | Normal     | Normal     | One     | Of course          | Smallest |

- ReadyToRun: If you extract the exe and run it alone, plugins cannot be loaded, and SP might not unlock.
- SelfContained: Not recommended for HDDs due to the large number of files.
- SingleFile: Requires separate installation of [.NET 10 Desktop Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet/thank-you/runtime-desktop-10.0.0-windows-x64-installer)
- ReadyToRun: Compression is enabled, so it takes 2-3 times the memory of SelfContained on startup. Don't worry, it only lasts a moment, and kernel-level cleanup is forced after startup.

> [!IMPORTANT]  
>
> Heads up: If you ask about the SingleFile runtime, I'll knife one person per query. I said it.<br>
> I already predicted someone would selectively go blind.

PluginExample is a sample plugin I made. Create a `Plugin` folder in the program directory, put the plugin inside, and restart 3FUI to load it. Plugins also need to match the architecture. The plugin suffix is **.3fui.dll**. If you can't see file extensions, go face the wall.

## FAQ

> [!IMPORTANT]  
>
> **What if nothing runs?** Check these in order:
>
> 1. Check if Windows Update has **.NET Framework 3.5, 4.8, and 4.8.1 cumulative updates** or anything that looks like it. If so, install them immediately. Don't doubt the name; Microsoft is just lazy with renaming. Your system is missing the relevant patches, installing them fixes it instantly.
>    - What, your system update is broken? That's karma! Who told you to trust those "optimization bloggers"~
> 2. Starting from official version 1.0, the compilation target minimum system version is Win10 1809. Lower versions are left to fate. Actually, Win7 can still run it, as long as patches are complete, but it's just barely usable, and bugs are everywhere.
> 3. Check antivirus interception logs.
> 4. Clone the repo and compile it yourself.
> 5. It's hopeless, reinstall the system. Known old LTSC builds have no solution.

> **How to compile this project yourself?**  
>
> 1. Download and install **Visual Studio 2026**
>
> 2. Workload only needs **.NET Desktop Development**, optional components can all be discarded (depending on your needs)
> 3. Open the **.sln** file directly, remaining dependencies will be resolved automatically (requires internet)
> 4. Just run **Rebuild Solution**

> **Will using old versions kill me?**  
> Yes. I need the latest features and bug fixes, keeping up with the latest code standards.

## Screenshots
<img src="IMG\img2.png"  />
<img src="IMG\img3.png"  />

Note: Fonts are freely selectable, don't complain about ugly text.<br>
The font used in the demo is MiSans Demibold with MacType effects.

## Preparation Steps

1. First, download 3FUI
   - No matter how many times I repeat it, there will always be people who download the source code. md
   - A huge number of people don't even understand processor architecture. tmd
   - I can predict without looking at my fingers that someone will ask about the differences without reading the download instructions above.
2. Go to the [FFmpeg Official Site](https://ffmpeg.org/) to download the latest release. Both gyan.dev and BtbN releases are acceptable.
   - If choosing gyan.dev, download **ffmpeg-git-full**
   - If choosing BtbN, download **ffmpeg-master-latest-win64-gpl**
   - Do not choose the one with `lgpl` in the name, otherwise you'll ask why even libx264 won't run.
   - It's also not recommended to choose the one with `shared` in the name. I already predicted you didn't place the complete files.
   - If you want to compile ffmpeg yourself, you can try this [Fully automated build script](https://github.com/m-ab-s/media-autobuild_suite)
3. Place ffmpeg.exe, ffprobe.exe, ffplay.exe from the zip<br>
   into the FFmpegFreeUI main program folder.<br>
   Or add them to the environment variables, which is recommended.
   - Adding to environment variables means adding the **folder** containing these three exe files to the Path,<br>
     not adding the files themselves to the Path.

4. Then you can start using it.

## Basic Logic Flow

3FUI's basic logic is to set up the required content in the parameter panel first, then drag files directly into the encoding queue to start automatically. When a file is added to the encoding queue, a snapshot of the parameter panel settings is saved. Each task has its own snapshot data. The command line is forcefully generated when the task starts. You can update the task's snapshot data, reverse-read snapshots, etc., in the task management menu.

## Mechanisms and Usage Tips

### About Adding Tasks

Normally, it is recommended to drag files directly onto the encoding queue list view to add them. If you have other needs or many files to check, use the Prepare Files tab. Starting from version 3.0, when dragging files into the encoding queue, hold `Ctrl`, `Shift`, or `Alt` to open a separate parameter panel (judged upon releasing the mouse, so if you forgot to press, you can continue pressing before releasing; don't press multiple keys, not adapted). This allows you to use other schemes for the task without changing the main UI parameter panel.

> [!IMPORTANT]
>
> Windows Security Mechanism: When running with administrator privileges, all drag-and-drop operations fail. Admin privileges block drag messages. Although it can be partially recovered via redirection, it cannot be fully solved, making it a crippled version. I do not plan to implement this in the future.

### About Starting Tasks

It's normal for there to be a delay when starting tasks. This part of the code is handed over to background threads. The status has changed but hasn't refreshed to the UI yet. Of course, clicking start multiple times won't cause issues; there's a guard. Also, note that manual task starts have no quantity limits.

### About Driver Files

A `.sys` driver file is generated on startup? It's likely needed by the performance monitoring library. Anyway, I don't have this in my code. Normally, it should auto-delete after generation. I don't know why it doesn't auto-delete sometimes. What, you're worried about security? It's an open-source component, what bad thing do you think it can do.

### About Progress Getting Stuck

This is a Windows scheduling issue. 3FUI's list view progress refresh and the bottom progress refresh after selecting a task are two separate logic systems. Usually, the list view one gets stuck. Pay attention to **System state when tasks are running** in settings. This state can be overridden by other software calling this state, common in downloaders, players, games, etc. When preparing to leave or sleep, switching tasks and pausing/resuming can refresh this state.

If the computer has no monitor plugged in, please set **Prevent display sleep** to prevent progress refresh from getting stuck. When no physical display is available, GPU policies usually consider going straight to sleep, which puts the GDI+ drawing message pump to sleep, making it impossible to update progress after waking the screen. You can only restart the software, but Windows doesn't allow process reconnection, which is frustrating. If a monitor is plugged in and it still gets stuck after screen-off, also set prevent display sleep. Just turn off the monitor power when sleeping or leaving. **Laptop users: DO NOT CLOSE THE LID!** Keep it open!

## Feedback Channels

- 3FUI does not have prevention for garbage input. Abnormal operations easily trigger errors.
- Any loss caused by intentionally hunting bugs is unrelated to me.
- To report any issues, prioritize the QQ group, as written at the beginning of this file.
- **DO NOT REPORT ISSUES ON BILIBILI!** Comments get swept away easily; DMs usually just ask you to join the group.

### DO NOT FORTUNE-TELL!

<img src="IMG\img_rep.png" />

Select an incorrect task, click the **Capture N Errors** text at the bottom of the encoding queue to open the output log.

**Then send it to technical staff! DO NOT send it to your daily-life AI chatbots! I'm talking about things like Doubao!<br>
ffmpeg output does not always have specific reasons in all cases.<br>
Especially for "feature not supported" or "parameter incorrect", these cases without command lines are just fortune-telling.<br>
Even GPT and Claude might not guess accurately, let alone those AI training data in China!**

It's best to include the command line. If you don't want others to see your filenames, manually redact them!<br>
If possible, please provide detailed parameters of the input file. Many players can view this!

> Please do not let **me**, **group members**, **professionals**, or **laymen** engage in behaviors including but not limited to: fortune-telling, guessing, dream interpretation, divination, human-brain deduction, forced preaching, physics discussion, psionic ascension, void perturbation, attempting to enter quantum tunnels, etc. If any of these or similar behaviors occur, the user bears full responsibility for all consequences.

Important thing said three times: DO NOT FORTUNE-TELL! Provide complete info ASAP!  
Important thing said three times: DO NOT FORTUNE-TELL! Provide complete info ASAP!  
Important thing said three times: DO NOT FORTUNE-TELL! Provide complete info ASAP!

Does this person lack self-care ability? They aren't here for help, they're here for psychological comfort!

## License and Citations

- 3FUI uses the MIT open-source license, freely usable and distributable.
- SunnyUI Commercial License Certificate No.: PVIP2023080201
- Open-sourced only on GitHub. Source code seen on other platforms is not mine!

| Referenced Assembly                                                   | License         | Purpose                       |
| ------------------------------------------------------------ | -------------- | -------------------------- |
| [SunnyUI](https://gitee.com/yhuse/SunnyUI)                   | GPL-3.0-only   | Main UI Framework                 |
| [WindowsAPICodePack](https://github.com/contre/Windows-API-Code-Pack-1.1) | Microsoft License | Provides a more comfortable folder selection dialog |
| [LibreHardwareMonitorLib](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) | MPL-2.0        | Performance Monitoring                   |

Yes, that's all the third-party libraries. I didn't even use Json.NET. Tell me, isn't that lightweight enough?

## Beginner Guide

If you are a complete beginner with no knowledge of video technical parameters, it is recommended to learn the following first:

- Geekwan | Basic Video Parameter Science | [BV1nt411Q7S6](https://www.bilibili.com/video/BV1nt411Q7S6)
- Geekwan | Frame Rate Difference in Movies and Games | [BV19x411L7fH](https://www.bilibili.com/video/BV19x411L7fH)
- Media Storm | Video Container and Encoding | [BV1ws41157f8](https://www.bilibili.com/video/BV1ws41157f8)
- Media Storm | Color Depth and Chroma Subsampling | [BV1ds411T7F4](https://www.bilibili.com/video/BV1ds411T7F4)
- Media Storm | Old Stories of Frame Rate | [BV1hp4y1f7B5](https://www.bilibili.com/video/BV1hp4y1f7B5)
- 终末诗 | Video Compression Tutorial for Beginners | [Zhihu](https://zhuanlan.zhihu.com/p/1913258114746122747) This article contains extensive test result summaries and setup tutorials.<br>
  Beginners can learn a lot from this article. Read it before continuing below!!
- 终末诗 | 3FUI Getting Started Tutorial | [Zhihu](https://zhuanlan.zhihu.com/p/1943079795341623993)

Additionally, my repo's IMG folder contains test results for some encoders, data provided by group members.

### Concept Science: Container Format vs Codec Format

This is a widespread public misconception.

Since you're using 3FUI, you must understand this most basic concept: mp4 is a container format, not a codec format. There is no "mp4 codec". x264 is a codec format. mp4 is just the outer shell, which can contain x264, x265, av1, and other mainstream codecs inside. The rest follows suit, while mkv supports the widest range of codecs.

## Video Encoders

Recommended quality values are personal opinions for reference only. Please tune them yourself.<br>
Only some encoders are listed here, as there are too many.

| Category    | Encoder Name | Description                                                         | Recommended Quality Value                                                 |
| ----------- | -------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| Stream Copy      | copy           | Direct copy without re-encoding                                         |                                                              |
| H.266/VVC   | libvvenc       | Benchmark king, `faster` alone crushes everything. Huge decoding/encoding performance consumption, huge optimization space. Currently unsuitable for daily use and production environments. | Does not support crf<br>Specify by qp |
| H.266/VVC   | libx266        | Supposed to be the official 266 implementation, but still unreleased to date.                      |                                                              |
| AV1         | libaom-av1     | Official implementation, very slow,偏向 commercial. Suitable for running multi-instance single-thread tasks. Unsuitable for daily use. |                                                              |
| AV1         | libsvtav1      | Intel-led, multi-thread optimized, consumer-friendly, easily maxes out CPU. Daily recommendation. | crf=32~34 Comprehensive recommendation                                           |
| AV1         | av1_nvenc      | Supported starting from RTX 40 series, but RTX 50 series and above (9th gen NVENC) recommended. Can rival libsvtav1, surpasses in some scenarios. Strongly recommended for daily use. | cq=36 Visually lossless universal value, highly recommended. But note this is not suitable for already blurry content. |
| AV1         | av1_qsv        | Supported starting from ARC discrete GPUs, Ultra 100 iGPUs                               | Lacks testing global_quality=34                                   |
| AV1         | av1_amf        | Supported starting from 7000 series discrete, 780M iGPU. AMD cards are usually weak, but AV1 might be okay? | Lacks testing qp_i=34 and qp_p=34                                  |
| AV1         | librav1e       | Very slow, average comprehensive performance                                           |                                                              |
| H.265/HEVC  | libx265        | Current best choice, preferred by encoding groups                             | crf=23~25 Comprehensive recommendation                                           |
| H.265/HEVC  | hevc_nvenc     | Clear gap compared to libx265, but sufficient for daily basic needs.                    | cq=26~28 Comprehensive recommendation                                            |
| H.265/HEVC  | hevc_qsv       | Probably better than N-cards? Anyway, I-cards are quite good, usable for daily needs.         | global_quality=24                                            |
| H.265/HEVC  | hevc_amf       | Not recommended for AMD 265 daily use, unless you just want to transcode and don't care about anything else. | qp_i=28 and qp_p=28                                           |
| H.264/AVC   | libx264        | Honestly a bit outdated. Unless for legacy device compatibility, unnecessary for daily use.   | crf=23 Comprehensive recommendation                                              |
| H.264/AVC   | h264_nvenc     | Not recommended, unless you just want to transcode and don't care.                           |                                                              |
| H.264/AVC   | h264_qsv       | Not recommended, unless you just want to transcode and don't care.                           |                                                              |
| H.264/AVC   | h264_amf       | Highly not recommended. Just for fun. Not even recommended for pure transcoding.                       |                                                              |
| From Apple  | prores_ks      | Universal, but not recommended for daily use. ProRes itself has almost no compression. Only recommended for intermediate workflow stages. |                                                              |
| From Apple  | prores_aw      | Requires macOS                                                   |                                                              |
| From Google | libvpx-vp9     | VP9 is stronger than 264, weaker than 265.                                       |                                                              |
| From Google | libvpx         | This is VP8, slightly inferior to 264.                                     |                                                              |
| Disabled        | -vn            |                                                              |                                                              |

### Concept Science: Software Encoding vs Hardware Acceleration

This is a severe public misconception.

Software encoding uses the CPU. Hardware acceleration uses the GPU. So-called hardware acceleration isn't a real "acceleration" in the sense of the GPU helping the processor calculate. GPU encoding calls the GPU's dedicated encoding circuits via the GPU driver interface, letting the GPU calculate on its own. It's fast because it's dedicated circuitry, hence called GPU acceleration. There is no such thing as the processor and GPU encoding the same video simultaneously.

Although both generate standards-compliant media, they are completely different encoders. In compression ratio, the GPU is always weaker than the CPU. This is inevitable. GPU codec circuits are fixed. To improve GPU compression ratio, you can only hope the new GPU made improvements. CPUs, as long as the instruction set supports it, can run the latest algorithms. Software can update directly, but you can't re-etch GPU circuits.

When using CPU encoding, RAM is occupied. Higher video specs occupy more. For example, encoding a 4K video with libsvtav1, you should install at least 16GB RAM to run the task stably. At this spec, 32GB RAM is best to unleash full performance. When using GPU encoding, PCIE bandwidth and VRAM are occupied. VRAM requirements are usually low, but PCIE bandwidth requirements are higher. For example, N-cards 50 series encoding AV1 usually requires a PCIE 5.0 motherboard to avoid bandwidth bottlenecks, but encoding HEVC only needs PCIE 4.0x8 bandwidth.

### Concept Science: Lossy vs Lossless Encoding

All videos you normally watch in life are lossy encoded, unless you work in a related field. Here, lossy and lossless are technical terms, not visual ones. Human vision is very limited, just like you only notice colors are mixed from RGB when you put your eye right on the screen. Technical lossless encoding ensures every pixel's info is correct. Life videos change pixels with every re-encode, so they are lossy compressed. You wouldn't want a 1GB per second video anyway.

### NVIDIA NVENC Specs

https://developer.nvidia.com/video-encode-and-decode-gpu-support-matrix-new

So yes, 3090 equals 3060. If it's a single task, 5090 also equals 5050. Codec cores only differ in generation and count, not scale. Jensen Huang wouldn't be that stingy. So if you buy an N-card just for encoding/decoding, just buy the contemporary lowest model, e.g., RTX 5050 for the 50 series. ffmpeg also cannot correctly call multiple codec cores in a single task. Additionally, Jensen Huang limits the simultaneous call count for gaming cards, usually 8, meaning you can start about 8 ffmpeg instances calling the N-card simultaneously. Professional cards don't have this limit, giving them the edge in this aspect.

Still gotta credit Jensen Huang. Look how chilly the other two vendors' tables are.

### INTEL QSV Specs

https://en.wikipedia.org/wiki/Intel_Quick_Sync_Video

### AMD AMF Specs

- https://github.com/GPUOpen-LibrariesAndSDKs/AMF/wiki/GPU%20and%20APU%20HW%20Features%20and%20Support
- https://en.wikipedia.org/wiki/Video_Core_Next

### Concept Science: Preset

Controls how hard the encoder works to find ways to shrink the file. It's called a preset because it's a series of internal parameter schemes provided by the encoder official, acting as a scheme selector based on enabling different amounts of features and controlling algorithm complexity. For regular encoding and conversion, just select it instead of tweaking internal params. Theoretically, the highest and lowest presets produce huge file size differences, but in real life, the difference for most videos isn't large. So choose based on your cost budget.

If using GPU encoding, just select the highest preset. You don't lack this compute power!

### Concept Science: Profile

Controls the encoder's configuration tier, meaning which features need to be supported. This usually affects the encoding method, thus impacting playback compatibility on various devices. Preserving the original file's features usually means leaving this blank.

### Concept Science: Tune

Controls how the encoder specifically optimizes for certain video content or playback use. Content aspects like movies, animation, film grain, static images; Use aspects like faster decode speed, lower latency, etc. Usually not needed.

### Concept Science: Pixel Format pix_fmt

Sets how pixels are stored, affecting color space, bit depth, channel arrangement, etc.

To minimize video size, RGB values are usually converted to YUV sampling. Y is luminance, UV are two chrominances. Since human eyes are sensitive to luminance but less so to chrominance, the videos we watch usually share one UV for every four pixels in a square range, while luminance Y is kept for every pixel. This way, even though a significant portion of data is dropped, you still won't notice quality loss because the decoder calculates the missing chrominance during playback. You still see complete RGB. After all, human vision limitations are too big. How could you think the calculated ones are fake? Even if you knew, so what? Life goes on.

This is yuv420. But the name doesn't specify memory layout, i.e., how these three samplings are arranged. You don't need to worry about this unless your playback device doesn't support it. Our commonly used yuv420p means these three samplings are stored separately in order. `p` stands for planar. nv12, nv21, p010le, etc., are also 420 samplings, just with different chrominance layouts. No good or bad.

Besides color type, there's the precision parameter, commonly known as 8bit, 10bit, etc. For example, yuv420p, nv12, nv21 are 8bit, while yuv420p10le, p010le are 10bit. This precision doesn't affect data size; it only decides color accuracy. 8bit pixels can only have **256^3=16,777,216** (~16.7 million) colors, while 10bit pixels can have **1024^3=1,073,741,824** (over 1 billion) colors. Although we've watched 8bit videos for a long time, you must admit higher precision helps encoding and improves various filter effects.

### Color Space

The concept of color space is actually quite deep. You don't need to understand it deeply, just remember the commonly used values.

|          | Standard Range SDR | High Dynamic Range HDR         |
| -------- | ------------ | ---------------------- |
| Matrix Coefficients | bt709        | bt2020nc<br>bt2020c    |
| Color Primaries     | bt709        | bt2020                 |
| Transfer Characteristic | bt709        | bt2020-10<br>smpte2084 |

As for color range selection, it depends on your use. It's generally recommended to match the original video. Many players can view file params. Just check and copy. Counter-intuitively: most videos in life are actually limited range, not full range.

If you have other needs, just ask AI for a parameter combo. 3FUI provides two conversion filters. If you want to convert Dolby Vision, it's recommended to use the GPU-accelerated libplacebo, and selecting `auto` for the tone mapping algorithm can usually automatically convert Dolby Vision to normal colors.

HDR standards are actually quite messy. Besides display color accuracy, peak brightness is also a very important parameter. But you should clearly know that ordinary human eyes simply cannot handle high-spec HDR. It's double the damage for minors, basically a civilian flashbang.

## Video Quality Control

Only need to use:

- **Constant Quality CRF**: First choice for software encoding, auto-selects crf
- **Variable Bitrate VBR**: First choice for hardware acceleration, auto-selects cq. VBR HQ is similar.

> [!IMPORTANT]
>
> N-cards use cq, I-cards use global_quality, A-cards use qp_i and qp_p or global_quality

- **Variable Bitrate VBR HQ**: Dedicated to hardware acceleration. Note this heavily relies on GPU hardware iteration.
> [!IMPORTANT]
>
> Strongly recommend using on Blackwell architecture RTX 50 series. Note to update to the latest driver otherwise expectations won't be met.<br>
> Reference: [NVIDIA Video Codec SDK 13.0 Powered by NVIDIA Blackwell](https://developer.nvidia.cn/blog/nvidia-video-codec-sdk-13-0-powered-by-nvidia-blackwell)<br>
> RTX 50 series UHQ mode has massive improvements. Considering time and electricity costs, it's already on par with or crushing CPU encoding.<br>
> Just set `-tune` to `uhq` and use VBR HQ mode.<br>
> Under normal mode (without UHQ), av1_nvenc's standard answer is cq36 to stably achieve VMAF≥95.<br>
> Now in UHQ mode, av1_nvenc's recommended answer is cq38 to stably achieve VMAF≥96.<br>
> For anime and pure 2D simple content, cq40 and cq42 can also be used.<br>
> 42 is the extreme balance point, heavily content-dependent. Live-action should not use it.<br>
> Meanwhile, HEVC UHQ also got a massive boost on Blackwell, even chasing x265 medium.

This does not mean CPU encoding can be phased out. Professional workflows pursuing absolute quality still need CPU.

Not recommended:

- **Constant Quantization CQP**: Rarely used, mainly for research and specific scenarios. There is no such thing as CQP, but some encoders' `rc` really has this value. Anyway, don't use it for daily tasks.
- **Constant Bitrate CBR**: Only for messing around and fun.

Won't do at all:

- **Average Bitrate ABR**: No need for ABR. Just traditional transcoding writing bitrate directly.
- **Two-Pass Encoding TPE**: Too lazy to implement. Or just write custom params and save a preset.
- **Three-pass?** Stop joking.

Note to flexibly adjust quality values based on specific encoders and video content! Each encoder's quality baseline is different and is affected by video content. Tune it slowly based on your needs. Don't expect a one-step fix. You can't have your cake and eat it too. Encoding time, image quality, file size, decoding performance: you must give up at least one of these four. Don't try to have it all.

Videos that have already been encoded are almost impossible to compress further! For example, anime resources ripped from streaming platforms or released by encoding groups (limited to those that look well-compressed and already small). Maintaining visual quality, even converting 264 to AV1 will basically yield poor results. Don't use these few params to challenge encoding groups' skills! Unless you cheat, you can't beat them.

## Audio Encoders

Stream Copy, Disabled, AAC, FDK AAC, LAME MP3, Opus, FLAC, ALAC, WAV 16bit, WAV 24bit, WAV 32bit, WAV 64bit, AC3, EAC3, DTS Coherent Acoustics, TrueHD, True Audio, Vorbis, RealAudio, WavPack, LAME MP2, AMR-NB, AMR-WB

## Image Encoders

PNG, APNG, JPEG/JPG, WEBP, GIF, BMP, JPEG 2000, JPEG-LS, SVT JPEG XS, HDR, TIFF, DPX, OpenEXR

## More Features and Used Filters

- Scale maintaining aspect ratio: `scale`
- Crop: `crop`
- Deinterlace/Frame dropping: `mpdecimate=max=?` and `-vsync vfr`
- Frame interpolation: `minterpolate`. The effect is very average, but very stable, extremely fast, uses CPU processing, completely judder-free. Usable for casual temporary viewing with low demands. Only suitable for videos with little motion. Not suitable for 3D game recordings, movies with lots of motion, etc.
  - Best quality option: Motion compensation interpolation + weighted OBMC
- Motion blur: `tblend`. Only **Average with previous frame** yields normal results. Others require specific tuning.
- Super resolution: `libplacebo`
  - Supports custom shaders, e.g., Anime4K, FSRCNNX, etc. Download files yourself.
- Burn subtitles: `subtitles` and `ass`
- Color management: `zscale` and `libplacebo`
- Basic color grading: `eq`
- Denoising: `hqdn3d`, `nlmeans`, `atadenoise`, `bm3d`, AviSynth+ (avs)
  - For AviSynth+ denoising filter usage, refer to [AviSynth+.md](doc/AviSynth+.md)
- Sharpening: `unsharp`
- Deinterlacing: NTSC and PAL mainstream schemes included. Check source code for used filters.
- Angle flip: `transpose`
- Mirror flip: `hflip`, `vflip`
- Loudness normalization: `loudnorm`

## Editing Range

Use this companion tool for visual editing range selection: https://github.com/Lake1059/3fuiVideoHelper

## Startup Arguments

3FUI uses the same parameter calling method as FFmpeg. You can use any terminal to pass them, or pass them when launching from external programs, or test via shortcuts. These features conceptually use the plugin functionality. (Requires v5.0 and above)

| Parameter                | Purpose                        | Used When |
| ------------------- | --------------------------- | ------------ |
| -i [string]         | Input media file                | Software Launched   |
| -3fui_file [string] | Input preset file                | Software Launched   |
| -ffmpeg [string]... | Feed all subsequent parameters to ffmpeg | Software Launched   |
| -test               | For testing, pops up "Beep Beep"        | Software Launched   |
| fullscreen          | Fullscreen borderless mode              | Software Not Launched   |

- `-i` and `-3fui_file` must be used together, indicating using a specified preset file to task a specified media file. The preset file can directly specify the preset name in the Preset folder (Scheme Management).
- `-ffmpeg` is pure command mode. Everything following it will be passed to ffmpeg.
- Additionally, there are `-3fuiVideoHelperInPointTime` and `-3fuiVideoHelperOutPointTime` for passing editing range parameters.

## Remote Call

Enable remote call in settings to listen on a specified port. Tasks start upon receiving messages. Message data content is the same as startup arguments. This means 3FUI can be deployed in a massive LAN. As long as 3FUI can access the files, you can send tasks to the encoding machine's 3FUI from any PC in the LAN via other programs. Remote access is natural if permissions allow.

Note: The initiating program must send via UDP protocol, default port 10591.

(Requires v5.0 and above)

## Plugin Development

Through plugins, you can add various features to 3FUI to meet your needs. Just lay out the visualization like I did and generate the corresponding parameters. You can also choose to integrate with my encoding queue instead of making your own progress display.

Considering the `ReadyToRun` generated exe cannot be added as a reference, plugins use **Reflection + Attributes + Dynamic Invocation** to implement. You don't need to reference 3FUI when developing plugins; just write code according to the interface standards I set. Currently, there are only 4 interface functions in total, very simple. Usually you only need to use 2 of them, so don't worry about grinding through code.

First, you need an IDE identical to mine for developing 3FUI:

1. Download and install [Visual Studio Community 2026](https://visualstudio.microsoft.com/zh-hans/vs/)
2. Workload check: .NET Desktop Development
   - Optional components depend on your needs, you can skip most.
   - But I still recommend: IntelliCode, .NET Portable Library Target Pack, .NET Profiling Tools
   - It should force install .NET 10 SDK. Remember to check.
3. Finish VS2026 installation.

Then you can start developing, beginning with a new project:

1. Create a **Windows Forms App** project using VB or C#.
   - If you're better with WPF, you can choose that.
   - But I don't know WPF. If the code below isn't written that way, you'll have to figure it out yourself.
   - Target framework must match 3FUI, select .NET 10.
   - I know you'll wonder why developing a plugin requires a Forms App instead of a Class Library. It's actually a VS limitation. To make a UI, you must choose this, otherwise there's no visualization.
2. After creating the project, close the default Form1. We don't need it.
   - But don't delete it, otherwise you can't build.
   - Or you can use it for testing, otherwise you can't debug your design.
   - In fact, we don't need to "launch" this project.
3. Create a new `Entry` class.
4. Write an `Entry` method in this `Entry` class. It must be Shared/Static.

   - VB language:
     ```vb
     Public Shared Sub Entry()
     	'Write initialization code here. Executes after 3FUI starts.
     End Sub
     ```
   - C# language:
     ```c#
     public static void Entry()
     {
     	// Write initialization code here. Executes after 3FUI starts.
     }
     ```

Now you've completed the plugin initialization method. Confirm: there is a method named `Entry` inside a class named `Entry`. Next, use interfaces to implement key functions. Just copy the code below and modify it yourself.

### Add Custom WinForm UI

To add your own UI to 3FUI's plugin extension tab, you must create your own user control, integrate all your functions into it, then copy the following code into your `Entry` class:

VB language:
```vb
Public Shared Property HostCall_AddCustomWinformPanel As Action(Of String, Control)
Public Shared Sub SetHost_AddCustomWinformPanel(action As Object)
	HostCall_AddCustomWinformPanel = CType(action, Action(Of String, Control))
End Sub

'Call
HostCall_AddCustomWinformPanel.Invoke("Name displayed in dropdown", New CustomControl)
```

C# language:
```c#
public static Action<string, Control> HostCall_AddCustomWinformPanel { get; set; }
public static void SetHost_AddCustomWinformPanel(object action)
{
	HostCall_AddCustomWinformPanel = (Action<string, Control>)action;
}

//Call
HostCall_AddCustomWinformPanel?.Invoke("Name displayed in dropdown", new CustomControl());
```

- Do not change the `HostCall` definition and `SetHost` method, otherwise 3FUI cannot call correctly.
- The method to add custom UI must be called within the `Entry` method, because I won't refresh that dropdown elsewhere. If you add UI elsewhere, it won't appear in the dropdown.
- The above content will not be repeated later.

Normally, just `New` the UI in this process. If you have advanced needs, you can `New` it elsewhere, but remember adding it to 3FUI must be executed inside the `Entry` method.

### Add Custom WPF UI

If you are better with WPF, use another interface.

VB language:
```vb
Public Shared Property HostCall_AddCustomWpfPanel As Action(Of String, UIElement)
Public Shared Sub SetHost_AddCustomWpfPanel(action As Object)
	HostCall_AddCustomWpfPanel = CType(action, Action(Of String, UIElement))
End Sub
    
'Call
HostCall_AddCustomWpfPanel.Invoke("Name displayed in dropdown", New CustomControl)
```

C# language:
```c#
public static Action<string, UIElement> HostCall_AddCustomWpfPanel { get; set; }
public static void SetHost_AddCustomWpfPanel(object action)
{
	HostCall_AddCustomWpfPanel = (Action<string, UIElement>)action;
}

//Call
HostCall_AddCustomWpfPanel?.Invoke("Name displayed in dropdown", new CustomControl());
```

### Add Encoding Tasks to Queue

Similarly simple way to add your encoding tasks to 3FUI's encoding queue. Since v2.0, there are two ways to add. One uses command lines; tasks added this way do not include preset data and cannot use reconfiguration features. The other uses 3FUI preset files; tasks added this way can use full features. Note that each added task reads the preset file once. This method is not specifically designed for batch addition needs.

VB language:
```vb
'Add using FFmpeg command line
Public Shared Property HostCall_AddMissionToQueueWithArgs As Action(Of String, String, String, String)
Public Shared Sub SetHost_AddMissionToQueueWithArgs(action As Object)
	HostCall_AddMissionToQueueWithArgs = CType(action, Action(Of String, String, String, String))
End Sub

'Call
HostCall_AddMissionToQueueWithArgs.Invoke("Parameters for ffmpeg, do not start with ffmpeg", "Filename displayed in encoding queue, can also show other info", "Output file path, used for locating output in encoding queue", "Input file path, can be left blank")
```

```vb
'Add using 3FUI preset file
Public Shared Property HostCall_AddMissionToQueueWith3fuiFile As Action(Of String, String, String, String)
Public Shared Sub SetHost_AddMissionToQueueWith3fuiFile(action As Object)
	HostCall_AddMissionToQueueWith3fuiFile = CType(action, Action(Of String, String, String, String))
End Sub

'Call
HostCall_AddMissionToQueueWith3fuiFile.Invoke("Path to 3FUI preset file", "Filename displayed in encoding queue, can also show other info", "Output file path, used for locating output in encoding queue", "Input file path, can be left blank")
```

C# language:
```c#
//Add using FFmpeg command line
public static Action<string, string, string, string> HostCall_AddMissionToQueueWithArgs { get; set; }
public static void SetHost_AddMissionToQueueWithArgs(object action)
{
	HostCall_AddMissionToQueueWithArgs = (Action<string, string, string, string>)action;
}

//Call
HostCall_AddMissionToQueueWithArgs?.Invoke("Parameters for ffmpeg, do not start with ffmpeg", "Filename displayed in encoding queue, can also show other info", "Output file path, used for locating output in encoding queue", "Input file path, can be left blank");
```

```c#
//Add using 3FUI preset file
public static Action<string, string, string, string> HostCall_AddMissionToQueueWith3fuiFile { get; set; }
public static void SetHost_AddMissionToQueueWith3fuiFile(object action)
{
	HostCall_AddMissionToQueueWith3fuiFile = (Action<string, string, string, string>)action;
}

//Call
HostCall_AddMissionToQueueWith3fuiFile?.Invoke("Path to 3FUI preset file", "Filename displayed in encoding queue, can also show other info", "Output file path, used for locating output in encoding queue", "Input file path, can be left blank");
```

### Media Stream Visual Selector

Starting from v5.1, a visual media stream selector was added. Thanks to excellent design logic, this feature not only perfectly integrates with 3FUI's existing functions but can also serve your own functions via plugin calls. *However, from a long-term perspective, it's not recommended for plugins to use this feature, as it has too many parameters, and this calling method cannot customize parameter order, making it messy.*

VB language:
```vb
Public Shared Property HostCall_MediaStreamVisualSelector As Action(Of String, Object, Object, Object, String, String, String, String)
Public Shared Sub SetHost_MediaStreamVisualSelector(action As Object)
	HostCall_AddMissionToQueueWithArgs = CType(action, Action(Of String, Object, Object, Object, String, String, String, String))
End Sub

'Call, note all parameters are optional. If not needed, just pass nothing.
HostCall_MediaStreamVisualSelector.Invoke(
        "FilePath", 'String, specifies the file for ffprobe to read. If file exists, window auto-starts on open.
        VideoStreamTargetObject, 'Object, but must have Text property. Specifies where to output video stream selection result.
        AudioStreamTargetObject, 'Same as above, specifies where to output audio stream selection result.
        SubtitleStreamTargetObject, 'Same as above, specifies where to output subtitle stream selection result.
        "InputFileIndex", 'String, selector can only select streams for one file. If you want output to include file index, specify which index file this is. Outputs like: 0:v:0,0:v:1. If not set, outputs comma-separated numbers: 0,1,2
        "VideoStreamSelected", 'String, if user already selected specified video stream, set this property to auto-check it. Format must be comma-separated direct index: 0,1,2. Cannot contain other chars.
        "AudioStreamSelected", 'Same as above, specifies selected audio stream.
        "SubtitleStreamSelected", 'Same as above, specifies selected subtitle stream.
        )
```

C# version is too long, let AI translate it directly.

### Publish Your Plugin

When development and testing are complete, click Build to get your plugin in the output directory. We chose Forms App earlier, so it generates an exe file. But since .NET 5, this exe is a pure binary stub. The code is in the dll file with the same name. At this time, copy this same-named dll alone, change its extension from `.dll` to `.3fui.dll`. This file is now the plugin you want to publish. The exe is completely unnecessary.

If you referenced other third-party components, publish those files together. Of course, don't change their extensions. 3FUI uses this extension to identify which files are plugins to load.

Since you did not reference 3FUI, relevant license terms do not apply to you. Therefore, you can choose to close-source or even sell it (though this won't protect your code, .NET programs are very easy to decompile).

## You've Unlocked Achievement

- Finished reading this md file, defeating 99% of users worldwide.
- Or you just scrolled to the bottom, defeating 50% of users worldwide.
