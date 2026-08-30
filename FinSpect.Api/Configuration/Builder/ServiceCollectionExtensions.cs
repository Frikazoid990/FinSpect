using FinSpect.Api.Configuration.Builder.Extensions;
using FinSpect.Api.Configuration.DI;

namespace FinSpect.Api.Configuration.Builder;

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