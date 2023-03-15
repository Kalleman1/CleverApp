using CleverAppen.Views;
using CommunityToolkit.Maui.Views;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
        DisplayAccountPopUp();
        
    }

    private void AccountButton_Clicked(object sender, EventArgs e)
    {

    }

    public void DisplayAccountPopUp()
    {
        var popup = new AccountPopUp();

        this.ShowPopup(popup);
    }
}
