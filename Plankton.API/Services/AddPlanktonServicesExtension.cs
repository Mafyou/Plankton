namespace Plankton.API.Services;

public static class AddPlanktonServicesExtension
{
    public static IServiceCollection AddPlanktonServices(this IServiceCollection services)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddApplicationInsightsTelemetry();
        return services;
    }
}
