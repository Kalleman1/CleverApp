using CleverAppen.Views;

namespace CleverAppen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    private async void AddButton_Clicked(object sender, EventArgs e)
    {
        //string answer = await DisplayActionSheet("Add invoice", "Cancel", null, "Upload document from device", "Scan Document with camera");
        await Navigation.PushAsync(new AccountPage()); 
    }

    private void AccountButton_Clicked(object sender, EventArgs e)
    {

    }
}
