namespace Plankton.API.Services;

public static class AddPlanktonServicesExtension
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPlanktonServices()
        {
            services.AddOpenApi();
            services.AddApplicationInsightsTelemetry();
            return services;
        }
    }
}
