namespace FinSpect.Api.Configuration.Extensions;

public static class SwaggerServiceExtansion
{
    public static IServiceCollection AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen();
        
        return services;
    }
}