namespace MauiComm_IssueShellPopup;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		// MainPage = new NavigationPage(new Page1());
	}
}
