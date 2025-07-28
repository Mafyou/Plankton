using Plankton.API.Helpers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPlanktonServices();

var app = builder.Build();

app.UsePlanktonMiddlewares();


// Feed received from the client is encrypted, so we need to decrypt it
app.MapPost("/race", (FeedCryptedDTO? feed) =>
{
    if (!ValidatingPlanklon.IsValidToDecrypt(feed))
    {
        return Results.Problem(
            title: "Invalid Feed",
            detail: "The provided feed data is not valid for decryption",
            statusCode: 400);
    }
    var key = Encoding.UTF8.GetBytes("E546C8DF278CD5931069B522E695D4F2");
    var feedDecrypted = CipherDecrypt.DecryptCipher(feed!.Value.Kind, key);
    var countDecrypted = CipherDecrypt.DecryptCipher(feed!.Value.Count, key);
    if (!int.TryParse(countDecrypted, out var count))
    {
        return Results.Problem(
            title: "Invalid Count",
            detail: "The decrypted count value is not a valid integer",
            statusCode: 400);
    }
    return Results.Ok(new FeedDTO { Kind = feedDecrypted, Count = count });
})
.WithOpenApi();

app.Run();