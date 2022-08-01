# DotNetGuiApp
.Net Maui Gui App



- For Windows:
  1. In the Enable Developer Mode for Windows dialog, click the settings for developers link to open the Settings app:
  2. Turn on the toggle under Developer Mode.
  3. The Use developer features dialog is displayed. Select Yes to confirm that you want to enable the developer mode.
  4. Close the Settings app, and then close the Enable Developer Mode for Windows dialog. The app should start running.


- For MacOS:
  1. Go to Xcode > Preferences > Locations > Command Line Tools and set the blank drop down to something other than blank. Restart your Visual Studio (or VSCode).
  2. Fixes: /usr/local/share/dotnet/packs/Microsoft.MacCatalyst.Sdk/15.4.442/tools/msbuild/iOS/Xamarin.Shared.targets(3,3): Error: Could not find a valid Xcode app bundle at '/Library/Developer/CommandLineTools'. Please update your Apple SDK location in Visual Studio's preferences (Projects > SDK Locations > Apple > Apple SDK).


References:
https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro
