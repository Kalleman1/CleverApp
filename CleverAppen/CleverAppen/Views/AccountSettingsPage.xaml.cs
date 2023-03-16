using CommunityToolkit.Maui.Views;

namespace CleverAppen.Views;

public partial class AccountSettingsPage : ContentPage
{

	public AccountSettingsPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        int pageCount = Navigation.NavigationStack.Count;
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 0)
        {
            await Navigation.PopAsync();
        }
    }
}