using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace MauiShell;

public partial class App : Microsoft.Maui.Controls.Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
    }
}
