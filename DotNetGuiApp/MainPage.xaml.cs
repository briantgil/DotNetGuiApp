namespace DotNetGuiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        var os = Environment.OSVersion;
        PlatformLabel.Text = os.Platform.ToString();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		//count += 10;

        if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


