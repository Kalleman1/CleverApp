using CleverAppen.Views;
using System.Security.Cryptography.X509Certificates;

namespace CleverAppen;

public partial class App : Application
{
	public static Page RootPage { get; set; }
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new AppShell());

        //MainPage = new NavigationPage(new AppShell());

        App.RootPage = MainPage; 

	}
}
