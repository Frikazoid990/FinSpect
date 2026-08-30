using Asp.Versioning;

namespace FinSpect.Api.Configuration.Builder.Extensions;

public static class ApiVersioningService
{
    public static IServiceCollection AddApiVersioningServices(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1,0);
        });
        
        return  services;
    }
}