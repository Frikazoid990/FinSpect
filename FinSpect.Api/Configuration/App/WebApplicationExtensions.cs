using FinSpect.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;

namespace FinSpect.Api.Configuration.App;

public static class WebApplicationExtensions
{
    public static WebApplication CreateApplication(this WebApplicationBuilder builder)
    {
        var isAllowedMigration = builder.Configuration.GetSection("AllowMigration").Get<bool>();
        var app = builder.Build();
        
        app.MapControllers();

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UpdateDatabase(isAllowedMigration);
        
        return app;
    }

    private static async Task UpdateDatabase(this WebApplication app, bool isAllowedMigration)
    {
        if (!isAllowedMigration)
        {
            return;
        }
        var logger = app.Services.GetRequiredService<ILogger<AppDbContext>>();
        using var scope = app.Services.CreateScope();
        try
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            logger.LogInformation("Migrating database associated with context {DbContextName}", dbContext);
            //узнать версию мииграции с текущей в прилоежнии и возможность не вызывать это
            await dbContext.Database.MigrateAsync(CancellationToken.None);
        }
        catch (Exception ex)
        {
            logger.LogError("The migration ended in failure");
        }

    }
}
