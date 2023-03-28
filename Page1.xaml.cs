namespace MauiComm_IssueShellPopup;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private async void btnNextPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new Page2(), false);
        // await Navigation.PushAsync(new Page2(), false);
    }
}

