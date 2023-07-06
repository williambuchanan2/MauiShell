namespace MauiShell;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    public static void SwitchToMainShellItem()
    {
        NavigationUtil.NavigateShell(nameof(MainShellItem));
    }


}
