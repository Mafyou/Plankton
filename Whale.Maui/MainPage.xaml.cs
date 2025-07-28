namespace Whale.Maui;

public partial class MainPage : ContentPage
{
    public MainPage(MainVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}