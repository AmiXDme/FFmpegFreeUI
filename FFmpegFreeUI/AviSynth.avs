LoadPlugin("C:\xxxx\LSMASHSource.dll")
LoadPlugin("C:\xxxx\fmtconv.dll")
LoadPlugin("C:\xxxx\knlmeanscl.dll")
LWLibavVideoSource("<FilePath>")# Read video stream from file
fmtc_bitdepth(bits=16,dmode=1)# Increase bit depth for KNLMeansCL denoising
KNLMeansCL(d=2,a=3,s=4,h=3,channels="Y",wmode=3)# Denoising intensity for luma plane is higher than chroma plane
KNLMeansCL(d=2,a=3,s=4,h=2,channels="UV",wmode=3)# Denoising intensity for chroma plane is lower than luma plane
fmtc_bitdepth(bits=10,dmode=0)# Decrease bit depth for libsvtav1 encoding
