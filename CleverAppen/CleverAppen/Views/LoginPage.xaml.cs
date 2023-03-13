using CleverAppen; 
namespace CleverAppen.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		NavigationPage.SetHasNavigationBar(this, false);
		NavigationPage.SetBackButtonTitle(this, null); 
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
		if (UsernameTextBox.Text == "123" && PasswordTextBox.Text == "123")
		{
			Navigation.PushAsync(new AppShell()); 
		}
		else
		{
			DisplayAlert("There was an error logging you in.", "The password and/or username you entered was wrong.", "Ok"); 
		}
    }
}