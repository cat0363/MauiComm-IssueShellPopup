using CommunityToolkit.Maui.Views;

namespace MauiComm_IssueShellPopup;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Navigated To Event
    /// </summary>
    /// <param name="args">Event Args</param>
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        // Create Popup
        PopupIndicator popup = new PopupIndicator();
        // Show Popup
        this.ShowPopup(popup);

        // Do Something
        await Task.Delay(3000);

        // Close Popup
        popup.Close();

        base.OnNavigatedTo(args);
    }

}