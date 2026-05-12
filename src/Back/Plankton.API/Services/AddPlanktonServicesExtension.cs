namespace Plankton.API.Services;

public static class AddPlanktonServicesExtension
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPlanktonServices(IConfiguration configuration)
        {
            services.AddOpenApi();

            var connectionString =
                configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"] ??
                configuration["ApplicationInsights:ConnectionString"] ??
                configuration["APPINSIGHTS_CONNECTIONSTRING"];

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                services.AddApplicationInsightsTelemetry(options =>
                {
                    options.ConnectionString = connectionString;
                });
            }

            return services;
        }
    }
}
