using CleverAppen.Views;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Maui.Views;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AccountSettingsPage), typeof(AccountSettingsPage));

        int pageCount = Navigation.NavigationStack.Count;
    }

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
        
        
    }

    private void AccountButton_Clicked(object sender, EventArgs e)
    {
        DisplayAccountPopUp();
    }

    public void DisplayAccountPopUp()
    {
        var popup = new AccountPopUp();

        this.ShowPopup(popup);
    }
}
