using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Maui.HotReload;
using CleverAppen.Service;
using CleverAppen.ViewModels;
using CleverAppen.Views;

namespace CleverAppen;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<ProductsPage>();
        builder.Services.AddSingleton<ProductService>();
        builder.Services.AddTransient<ProductViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }

}