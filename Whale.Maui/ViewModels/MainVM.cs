using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plankton.DTO;
using Plankton.RaceHelper;
using Whale.Maui.Services;

namespace Whale.Maui.ViewModels;

public partial class MainVM : ObservableObject
{
    [ObservableProperty]
    private string _status = "Ready ?";
    private readonly APIService _api;
    [RelayCommand]
    private async Task onUpdateStatus()
    {
        var result = await TaskGoup.RunScopeAsync(default, async group =>
        {
            return await TaskGoup.RaceScopeAsync<FeedDTO>(group.CancellationToken, async group =>
            {
                Parallel.For(1, 5000, (index) =>
                {
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedDTO { Kind = "Little", Count = index.ToString() }));
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedDTO { Kind = "Big", Count = index.ToString() }));
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedDTO { Kind = "Average", Count = index.ToString() }));
                });
            });
        });
        Status = $"You fed me by {result.Kind} with {result.Count} plankton";

        SemanticScreenReader.Announce(Status);
    }
    public MainVM(APIService api)
    {
        _api = api;
    }
}
