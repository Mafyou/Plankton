using System.Collections.ObjectModel;

namespace Whale.Maui.ViewModels;

public partial class MainVM(IAPIService api) : ObservableObject
{
    [ObservableProperty]
    private string _status = "Ready ?";

    [ObservableProperty]
    private string _numberOfFeeds = "10";

    [ObservableProperty]
    private bool _hasResults = false;

    [ObservableProperty]
    private ObservableCollection<FeedResultItem> _feedResults = new();

    private readonly IAPIService _api = api;

    [RelayCommand]
    private async Task OnUpdateStatusAsync()
    {
        if (!int.TryParse(NumberOfFeeds, out int feedCount) || feedCount <= 0)
        {
            Status = "Please enter a valid number of feeds";
            return;
        }

        FeedResults.Clear();
        HasResults = false;
        Status = $"Racing {feedCount} feeds...";

        var results = await TaskGoup.RunScopeAsync(default, async group =>
        {
            var allResults = new List<FeedDTO>();

            await TaskGoup.RaceScopeAsync<FeedDTO>(group.CancellationToken, raceGroup =>
            {
                Parallel.For(1, feedCount + 1, (index) =>
                {
                    raceGroup.Race(async token =>
                    {
                        var result = await _api.EncryptedFeedRace(new FeedCryptedDTO("Little", $"{index}"));
                        lock (allResults) { allResults.Add(result); }
                        return result;
                    });
                    raceGroup.Race(async token =>
                    {
                        var result = await _api.EncryptedFeedRace(new FeedCryptedDTO("Big", $"{index}"));
                        lock (allResults) { allResults.Add(result); }
                        return result;
                    });
                    raceGroup.Race(async token =>
                    {
                        var result = await _api.EncryptedFeedRace(new FeedCryptedDTO("Average", $"{index}"));
                        lock (allResults) { allResults.Add(result); }
                        return result;
                    });
                });
            });

            return allResults;
        });

        // Display results in ListView
        for (int i = 0; i < results.Count; i++)
        {
            FeedResults.Add(new FeedResultItem
            {
                Position = i + 1,
                Kind = results[i].Kind,
                Count = results[i].Count
            });
        }

        HasResults = FeedResults.Count > 0;
        var winner = results.FirstOrDefault();
        Status = winner != null ? $"Winner: {winner.Kind} with {winner.Count} plankton!" : "Race completed";

        SemanticScreenReader.Announce(Status);
    }
}
