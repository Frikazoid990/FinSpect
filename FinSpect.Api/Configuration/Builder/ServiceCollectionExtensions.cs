using FinSpect.Api.Configuration.DI;
using FinSpect.Api.Configuration.Extensions;

namespace FinSpect.Api.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFinSpectServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        
        //swagger
        services.AddSwaggerService();
        //ApiVersioning 
        services.AddApiVersioning();
        
        services.AddServices();
        services.AddControllers();
        return services;
    }
}