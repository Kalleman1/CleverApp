namespace CleverAppen.Views;

public partial class AccountSettingsPage : ContentPage
{
	public AccountSettingsPage accountSettings = new();
	public AppShell appShell = new AppShell();
	public AccountSettingsPage()
	{
		InitializeComponent();
		Navigation.InsertPageBefore(accountSettings, appShell);
    }
}