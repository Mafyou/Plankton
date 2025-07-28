namespace Whale.Maui.DisplayObjects;

public partial class FeedResultItem : ObservableObject
{
    [ObservableProperty]
    private int _position;

    [ObservableProperty]
    private string _kind;

    [ObservableProperty]
    private int _count;
}