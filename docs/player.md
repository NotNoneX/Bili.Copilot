# 播放器类型

> [!IMPORTANT]
> 开发者无法保证在各个平台都能顺利播放视频（很扯淡，但很真实）  
> Windows 硬件平台种类繁多，为了尽可能使得大多数用户至少能播放视频，开发者被迫嵌入了多种不同的播放器。  
> 如果某一种播放器你无法正常使用，这！很！正！常！，请切换到其它播放器类型播放视频。

## 如何更改播放器类型

请在应用设置里展开 `播放行为` 设置，第一个设置项就是播放器类型切换。

## 原生播放器

即 Windows App SDK 提供的 MediaPlayer。

兼容性较好，在各个硬件平台都具备基础的播放能力（大概，毕竟总有人中奖放不了视频）。

但是在网络条件不好的时候会缓冲很久。

适用人群：

1. 追求原生播放体验，且配置一般的设备
2. 喜欢播放杜比视界，且在设备上安装了 Dolby Access。

## MPV 播放器

内置的 mpv 播放器基于 libmpv，使用 OpenGL 解码渲染视频，然后与 DirectX 共享资源，最后渲染到 XAML 表面。

背靠 mpv，在解码能力上比较优秀，但是没有做针对杜比视界和 HDR 的色域映射。

适用人群：

1. NVDIA 显卡用户（内置 MPV 不兼容 AMD 显卡）
2. 高配置用户（30/40系显卡最好）

## 外部播放器

如果你的设备上安装了 mpv 或者 mpv.net，并希望使用它们播放视频，那么外部播放器就是推荐的播放器类型。

你可以完全自定义配置，创建完善的 HDR 或者杜比视界色域映射，充分享受视频播放的快乐。

适用人群：

1. 本机安装了 mpv / mpv.net 的用户。
2. 追求视听体验的玩家。

## 网页播放器

终极回退方案。

哔哩助理内嵌 WebView2，为其启用了本机解码能力，并内置了 BewlyBewly 美化插件。

当前面的播放器都无法在你的设备上工作，请选择网页播放器。（不会有人网页都放不了视频吧，不会吧，不会吧）

使用网页播放器，你就不必担心放不了视频了，同时内存占用相较于你打开浏览器，也会大幅降低。

