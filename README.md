# DotNetGuiApp
## Cross Platform .Net Maui Gui App


### Windows:
  1. Setup:
     1. In the Enable Developer Mode for Windows dialog, click the settings for developers link to open the Settings app
     2.  Turn on the toggle under Developer Mode.
     3.  The Use developer features dialog is displayed. Select Yes to confirm that you want to enable the developer mode.
     4.  Close the Settings app, and then close the Enable Developer Mode for Windows dialog. The app should start running.
  2. Both XAML Hot Reload and .NET Hot Reload (for C#) worked
  3. Publish signed MSIX by cd'ing to project folder:
     1. create certificate
     2. add thumbprint xml template to project (.csproj) file
     3. run: `dotnet publish -f net6.0-windows10.0.19041.0 -c Release`
     4. install app
     5. currently, the published app doesn't work if you try to run it directly with the executable file out of the publish folder.


### MacOS:
  1. Setup:
      1. Go to: Xcode > Preferences > Locations > Command Line Tools and set the blank drop down to something other than blank. Restart your Visual Studio (or VSCode).
      2. Fixes: /usr/local/share/dotnet/packs/Microsoft.MacCatalyst.Sdk/15.4.442/tools/msbuild/iOS/Xamarin.Shared.targets(3,3): Error: Could not find a valid Xcode app bundle at '/Library/Developer/CommandLineTools'. Please update your Apple SDK location in Visual Studio's preferences (Projects > SDK Locations > Apple > Apple SDK).
  2. XAML Hot Reload worked, but .NET Hot Reload (for C#) did not work since there was no "apply code changes" (ALT-F10) button in Visual Studio toolbar, may be able to use CLI: dotnet watch
  3. Publish unsigned by cd'ing to project folder and run:
      - .app: `dotnet build -f:net6.0-maccatalyst -c:Release`
      - .pkg: `dotnet build -f:net6.0-maccatalyst -c:Release -p:CreatePackage=true`

  
## Modified:
  1. MainPage.xaml
  2. MainPage.xaml.cs

  
## References:
1. [.NET MAUI Tutorial - Build your first multi-platform app in C#](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro)
2. [Error : Could not find a valid Xcode app bundle at '/Library/Developer/CommandLineTools' #3888](https://github.com/dotnet/maui/issues/3888)
3. [Introducing the .NET Hot Reload experience for editing code at runtime](https://devblogs.microsoft.com/dotnet/introducing-net-hot-reload/)
4. [Publish a .NET MAUI app for macOS](https://docs.microsoft.com/en-us/dotnet/maui/macos/deployment/overview)
5. [Open a Mac app from an unidentified developer](https://support.apple.com/en-gb/guide/mac-help/mh40616/mac)

