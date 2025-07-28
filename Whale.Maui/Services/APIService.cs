namespace Whale.Maui.Services;

public class APIService(IHttpClientFactory clientFactory) : IAPIService
{
    private readonly HttpClient _client = clientFactory.CreateClient("whale");

    public async Task<FeedDTO> EncryptedFeedRace(FeedCryptedDTO feed)
    {
        var encryptFeed = CryptFeedDTO(feed);
        var request = await _client.PostAsJsonAsync("/race", encryptFeed);
        if (request.IsSuccessStatusCode)
        {
            return await request.Content.ReadFromJsonAsync<FeedDTO>();
        }
        var pb = await request.Content.ReadFromJsonAsync<ProblemDetails>();
        throw new Exception($"{pb.Title} {pb.Detail}");
    }

    private static FeedCryptedDTO CryptFeedDTO(FeedCryptedDTO feedCrypted)
    {
        var key = Encoding.UTF8.GetBytes("E546C8DF278CD5931069B522E695D4F2");

        return new FeedCryptedDTO
        {
            Kind = CipherEncrypt.EncryptCipher(feedCrypted.Kind, key),
            Count = CipherEncrypt.EncryptCipher(feedCrypted.Count, key)
        };
    }
}
