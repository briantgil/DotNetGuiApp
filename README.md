# DotNetGuiApp
.Net Maui Gui App


- For Windows:
  1. In the Enable Developer Mode for Windows dialog, click the settings for developers link to open the Settings app:
     1.  Turn on the toggle under Developer Mode.
     2.  The Use developer features dialog is displayed. Select Yes to confirm that you want to enable the developer mode.
     3.  Close the Settings app, and then close the Enable Developer Mode for Windows dialog. The app should start running.
  2. Both XAML Hot Reload and .NET Hot Reload (for C#) worked


- For MacOS:
  1. Go to Xcode > Preferences > Locations > Command Line Tools and set the blank drop down to something other than blank. Restart your Visual Studio (or VSCode).
      1. Fixes: /usr/local/share/dotnet/packs/Microsoft.MacCatalyst.Sdk/15.4.442/tools/msbuild/iOS/Xamarin.Shared.targets(3,3): Error: Could not find a valid Xcode app bundle at '/Library/Developer/CommandLineTools'. Please update your Apple SDK location in Visual Studio's preferences (Projects > SDK Locations > Apple > Apple SDK).
  2. XAML Hot Reload worked, but .NET Hot Reload (for C#) did not work since there was no "apply code changes" (ALT-F10) button in your Visual Studio toolbar 
  3. Publish by cd to project folder and run:
      - dotnet build -f:net6.0-maccatalyst -c:Release

  
- Modified:
  1. MainPage.xaml
  2. MainPage.xaml.cs

  
References:

https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro

https://github.com/dotnet/maui/issues/3888

https://devblogs.microsoft.com/dotnet/introducing-net-hot-reload/

https://docs.microsoft.com/en-us/dotnet/maui/macos/deployment/overview

https://support.apple.com/en-gb/guide/mac-help/mh40616/mac

