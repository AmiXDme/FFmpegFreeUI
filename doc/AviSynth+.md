## AviSynth+ Denoising Filter

> This section content improved by hajimanbo

AviSynth options are provided in the denoising settings, it is the last option. 3FUI can only use avs files for loading. Before starting, it must be clear that 3FUI is designed as a batch processing transcoding tool, so this loading logic is inevitably designed this way. When using this filter, the avs file will replace the input file's position. By default, 3FUI assumes you will not process audio in the avs. To prevent beginners from discovering that the video sound is gone, custom parameters and stream control parameters are automatically overwritten when selecting this denoising. Please double-check.

First, download these dll files:

- AviSynth.dll (Look for the one named filesonly in the distribution) <br>https://github.com/AviSynth/AviSynthPlus/releases
- LSMASHSource.dll <br>https://github.com/HomeOfAviSynthPlusEvolution/L-SMASH-Works/releases <br>This file is used to read video files
- knlmeanscl.dll <br>https://github.com/Khanattila/KNLMeansCL/releases <br>This file is used for denoising
- fmtconv.dll <br>https://gitlab.com/EleonoreMizo/fmtconv <br>Used to change video bit depth

Put these files together with ffmpeg!

Create an AviSynth.avs file in the 3FUI directory as a template for 3FUI, and fill it with the following content:

```vb
LoadPlugin("C:\xxxx\LSMASHSource.dll")
LoadPlugin("C:\xxxx\fmtconv.dll")
LoadPlugin("C:\xxxx\knlmeanscl.dll")
LWLibavVideoSource("<FilePath>")#Read the video stream from the file
fmtc_bitdepth(bits=16,dmode=1)#Increase bit depth for KNLMeansCL denoising
KNLMeansCL(d=2,a=3,s=4,h=3,channels="Y",wmode=3)#Denoising intensity for brightness plane is higher than chroma plane
KNLMeansCL(d=2,a=3,s=4,h=2,channels="UV",wmode=3)#Denoising intensity for chroma plane is lower than brightness plane
fmtc_bitdepth(bits=10,dmode=0)#Decrease bit depth for libsvtav1 encoding
```

If you need to read audio and video streams from a file in avs, you can use the following template:

```vb
LoadPlugin("C:\xxxx\LSMASHSource.dll")
LoadPlugin("C:\xxxx\fmtconv.dll")
LoadPlugin("C:\xxxx\knlmeanscl.dll")
function LibavSource2(string path, int "atrack",
\          int "fpsnum", int "fpsden",
\          string "format", bool "cache")
{
    atrack   = Default(atrack, -1)
    fpsnum   = Default(fpsnum, 0)
    fpsden   = Default(fpsden,  1)
    cache    = Default(cache, true)

    format   = Default(format, "")

    video = LWLibavVideoSource(path,
    \               fpsnum=fpsnum, fpsden=fpsden, format=format,
    \               cache=cache)
    return (atrack==-2) ? video: AudioDub(video,
   \    LWLibavAudioSource(path, stream_index=atrack, cache=cache))
}
LibavSource2("<FilePath>")#Read audio and video streams from the file. atrack - audio track number, default is auto. If -2, ignore audio. cache - if true (default), create an index file
fmtc_bitdepth(bits=16,dmode=1)#Increase bit depth for KNLMeansCL denoising
KNLMeansCL(d=2,a=3,s=4,h=3,channels="Y",wmode=3)#Denoising intensity for brightness plane is higher than chroma plane
KNLMeansCL(d=2,a=3,s=4,h=2,channels="UV",wmode=3)#Denoising intensity for chroma plane is lower than brightness plane
fmtc_bitdepth(bits=10,dmode=0)#Decrease bit depth for libsvtav1 encoding
```

- The LoadPlugin method is used to load these dlls; AviSynth.dll does not need to be loaded here. <br>Please use absolute paths for dll paths!
- LWLibavVideoSource loads the video file. Directly copy the fourth line, and 3FUI will automatically replace this file path.
- fmtc_bitdepth is used to first increase bit depth for KNLMeansCL's denoising, and then decrease it for the video encoder's encoding.
- KNLMeansCL is the denoising method. Its parameters are as follows:

Original: https://github.com/Khanattila/KNLMeansCL/wiki/Filter-description

```c#
KNLMeansCL(clip, int d, int a, int s, float h, string channels, int wmode, float wref, clip rclip, string device_type, int device_id, bool lsb_inout, bool info)
```

| Parameter | Description                                                         |
| ----------- | ------------------------------------------------------------ |
| clip        | Do not write                                                         |
| d           | Number of reference frames before and after. d=0 uses 1 frame, d=1 uses 3 frames, n=2*d+1, and so on. Larger values result in better denoising effect. |
| a           | Search pixel radius. a=1 uses 9 pixels, a=2 uses 25 pixels, n=(2*a+1)^2, and so on. Larger values result in better denoising effect. |
| s           | Similarity radius, default = 4. Small impact on performance, depending on the nature of noise. |
| h           | Filtering strength, default = 1.2. Larger values remove more noise. |
| channels    | Set the color channels to denoise. Possible values are YUV, Y, UV. |
| wmode       | 0 := Welsch weighting function has a faster decay, but still assigns positive weights to dissimilar blocks. Original Non-local means denoising weighting function.<br/>1 := Modified Bisquare weighting function to be less robust.<br/>2 := Bisquare weighting function use a soft threshold to compare neighbourhoods (the weight is 0 as soon as a given threshold is exceeded).<br/>3 := Modified Bisquare weighting function to be even more robust. |
| wref        | Default = 1. Weight relative to the most similar pixel found, affecting the amount of original pixels in filter output. |
| rclip       | Do not write                                                         |
| device_type | accelerator, cpu, gpu, auto                                  |
| device_id   | Graphics card index                                                     |
| lsb_inout   | Not necessary                                                       |
| info        | Output additional information                                                 |
