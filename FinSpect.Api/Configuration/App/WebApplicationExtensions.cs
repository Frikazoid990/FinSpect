namespace FinSpect.Api.Configuration.App;

public static class WebApplicationExtensions
{
    public static WebApplication CreateApplication(this WebApplicationBuilder builder)
    {
        var app = builder.Build();
        
        app.MapControllers();

        app.UseSwagger();
        app.UseSwaggerUI();
        return app;
    }
}