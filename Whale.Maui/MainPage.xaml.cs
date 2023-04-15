using Whale.Maui.Services;
using Whale.Maui.ViewModels;

namespace Whale.Maui;

public partial class MainPage : ContentPage
{
    public MainPage(APIService api)
    {
        InitializeComponent();
        BindingContext = new MainVM(api);
    }
}