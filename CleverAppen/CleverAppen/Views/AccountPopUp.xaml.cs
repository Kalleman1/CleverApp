using CommunityToolkit.Maui.Views;

namespace CleverAppen.Views;

public partial class AccountPopUp : Popup
{
	public AccountPopUp()
	{
		InitializeComponent();
	}

    private void LogOutButton_Clicked(object sender, EventArgs e)
    {

    }

    private void SwitchCompanyButton_Clicked(object sender, EventArgs e)
    {

    }

    private async void AccountSettingsButton_Clicked(object sender, EventArgs e)
    {
        var accountSettingsPage = new AccountSettingsPage();

        if (App.Current.MainPage is NavigationPage navigationPage)
        {
            await navigationPage.PushAsync(accountSettingsPage);
            Close();
        }
    }
}