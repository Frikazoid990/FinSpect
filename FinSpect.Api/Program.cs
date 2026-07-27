using FinSpect.Api.Configuration;
using FinSpect.Api.Configuration.App;

namespace FinSpect.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddFinSpectServices();



        var app = builder.CreateApplication();
        
        app.Run();
    }
}