namespace Whale.Maui;

public partial class App : Application
{
    private readonly IAPIService _apiService;

    public App(IAPIService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage(new MainVM(_apiService)));
    }
}