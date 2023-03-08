using CleverAppen.Views;

namespace CleverAppen;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginPage()); 

		//if (IsAuthenticated())
		//{
		//	MainPage = new AppShell(); 
		//}
		//else
		//{
		//	MainPage = new LoginPage(); 	
		//}
	}

	//public bool IsAuthenticated()
	//{
	//	return false;
	//}
}
