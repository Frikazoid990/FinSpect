using FinSpect.Api.Configuration.DI;
using FinSpect.Api.Configuration.Extensions;

namespace FinSpect.Api.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFinSpectServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
        
        //
        services.AddSwaggerService();
        //
        services.AddApiVersioning();
        //
        services.AddDbConnection(configuration);
        
        services.AddServices();
        services.AddControllers();
        return services;
    }
}