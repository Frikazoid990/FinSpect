using FinSpect.Api.Configuration.Builder.Extensions;
using FinSpect.Api.Configuration.DI;
using FinSpect.Application.Common.Filters;

namespace FinSpect.Api.Configuration.Builder;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFinSpectServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddLogging();
        //
        services.AddSwaggerService();
        //
        services.AddApiVersioningServices();
        //
        services.AddDbConnection(configuration);

        services.AddServices();

        services.AddControllers(op =>
        {
            op.Filters.Add(typeof(ExceptionFilter));
        });
    return services;
    }
}