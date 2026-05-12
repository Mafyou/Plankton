namespace Plankton.API.Services;

public static class AddPlanktonServicesExtension
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPlanktonServices(IConfiguration configuration)
        {
            services.AddOpenApi();

            return services;
        }
    }
}