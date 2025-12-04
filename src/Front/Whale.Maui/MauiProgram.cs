namespace Whale.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        builder.Services.AddHttpClient("whale", client =>
        {
            client.BaseAddress = new Uri("https://planktonapi.azurewebsites.net");
        });
        builder.Services.AddSingleton<IAPIService, APIService>();
        builder.Services.AddTransientWithShellRoute<MainPage, MainVM>(nameof(MainPage));
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}