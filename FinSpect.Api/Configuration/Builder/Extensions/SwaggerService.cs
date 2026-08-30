namespace FinSpect.Api.Configuration.Builder.Extensions;

public static class SwaggerServiceExtension
{
    public static IServiceCollection AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen();
        
        return services;
    }
}