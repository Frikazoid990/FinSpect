using FinSpect.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FinSpect.Api.Configuration.Extensions;

public static class DataBaseConnectionService
{
    public static IServiceCollection AddDbConnection(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") 
                               ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found");
        services.AddDbContext<AppDbContext>(op =>
        {
            op.UseNpgsql(connectionString);
        });
        
        return services;
    }
}