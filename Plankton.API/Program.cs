using Plankton.CryptoHelper;
using Plankton.DTO;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/race", (FeedDTO feed) =>
{
    var key = Encoding.UTF8.GetBytes("E546C8DF278CD5931069B522E695D4F2");
    return new FeedDTO
    {
        Kind = CipherDecrypt.DecryptCipher(feed.Kind, key),
        Count = CipherDecrypt.DecryptCipher(feed.Count, key)
    };
})
.WithOpenApi();

app.Run();