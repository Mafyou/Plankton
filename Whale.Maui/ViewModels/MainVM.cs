namespace Whale.Maui.ViewModels;

public partial class MainVM(IAPIService api) : ObservableObject
{
    [ObservableProperty]
    private string _status = "Ready ?";
    private readonly IAPIService _api = api;
    [RelayCommand]
    private async Task OnUpdateStatusAsync()
    {
        var result = await TaskGoup.RunScopeAsync(default, async group =>
        {
            return await TaskGoup.RaceScopeAsync<FeedDTO>(group.CancellationToken, group =>
            {
                Parallel.For(1, 10, (index) =>
                {
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedCryptedDTO { Kind = "Little", Count = $"{index}" }));
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedCryptedDTO { Kind = "Big", Count = $"{index}" }));
                    group.Race(async token => await _api.EncryptedFeedRace(new FeedCryptedDTO { Kind = "Average", Count = $"{index}" }));
                });
            });
        });
        Status = $"You fed me by {result.Kind} with {result.Count} plankton";

        SemanticScreenReader.Announce(Status);
    }
}
