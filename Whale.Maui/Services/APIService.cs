using Microsoft.AspNetCore.Mvc;
using Plankton.CryptoHelper;
using Plankton.DTO;
using System.Net.Http.Json;
using System.Text;

namespace Whale.Maui.Services;

public class APIService
{
    private HttpClient _client;
    public APIService()
    {
        _client = new()
        {
            BaseAddress = new Uri("https://planktonapi.azurewebsites.net"),
        };
    }
    public async Task<FeedDTO> EncryptedFeedRace(FeedDTO feed)
    {
        var encryptUser = cryptFeedDTO(feed);
        var request = await _client.PostAsJsonAsync("/race", encryptUser);
        if (request.IsSuccessStatusCode)
        {
            return await request.Content.ReadFromJsonAsync<FeedDTO>();
        }
        var pb = await request.Content.ReadFromJsonAsync<ProblemDetails>();
        throw new Exception($"{pb.Title} {pb.Detail}");
    }

    private FeedDTO cryptFeedDTO(FeedDTO feed)
    {
        var key = Encoding.UTF8.GetBytes("E546C8DF278CD5931069B522E695D4F2");

        return new FeedDTO
        {
            Kind = CipherEncrypt.EncryptCipher(feed.Kind, key),
            Count = CipherEncrypt.EncryptCipher(feed.Count, key)
        };
    }
}
