# Avalonia Test Drive

A Simple Temperature Conversion Application with Avalonia UI.

Avalonia UI is a new modern .NET cross-platform application framework with C# and XAML, heavily inspired by WPF

[Avalonia UI - GitHub](https://github.com/AvaloniaUI/Avalonia)

## First Impressions

There are lot of pluses:
- Incredible Tooling support (especially with Jetbrains Rider)
- Applications are extremely fast, compared to WinUI (WinUI3 was bit laggy even with new fluent design native controls)
- Fast build times, again compared to UWP and WinUI - WinUI have very slow first-time builds and sometimes it throws random errors even when running a freshly-created project.
- Easy to get going (Honestly I faced some bumps, due to my very basic knowledge of WPF)
- Intuitive Styling similar to CSS (Not compact as CSS but still beneficial for desktop frameworks)
- Very similar to WPF (I was able to learn things in Avalonia by seeing WPF tutorials!)
- Thumbs-up for Windows support all the way to Windows 7 which I find rare among cross-platform frameworks these days.

Specifically, I feel it more similar to Flutter, in terms of architecture and principles. But with even with two languages together - XAML and C#, I am still surprisingly productive, quite like Flutter. May be its due to the excellent intellisense in Rider, but overall developer experience is lit 🔥. But the documentation were lacking for bit advanced scenarios. I had little bit trouble when no specific guides for using Dependency Injection and MVVM with `CommunityToolkit.Mvvm`, but they must be pretty much doable by any experienced WPF developer. I am more of a beginner in WPF, so I had to do some trial and error.

I haven't tried out other supported platforms yet, especially I have no idea how mobile support will fare, as being a desktop-first platform. Besides, again like flutter, it's a UI-only framework and need platform-specific code or third-party libraries for native functionalities. But I guess, `Microsoft.Maui.Essentials` package can be used for platform features. Couldn't find proper documentation for that either. But still not a deal-breaker, for a framework that had its first stable release just a few months ago.

Overall, I am very impressed with Avalonia and I am looking forward to use it in my future projects. No surprise why JetBrains is sponsoring them!
