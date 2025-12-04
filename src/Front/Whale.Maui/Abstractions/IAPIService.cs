namespace Whale.Maui.Abstractions;

public interface IAPIService
{
    Task<FeedDTO> EncryptedFeedRace(FeedCryptedDTO feedCrypted);
}