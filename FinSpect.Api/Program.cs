using System.ComponentModel;
using FinSpect.Api.Configuration;
using FinSpect.Api.Configuration.App;
using FinSpect.Api.Configuration.Builder;
using FinSpect.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.Console;

namespace FinSpect.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddFinSpectServices(builder.Configuration);
        
        var app = builder.CreateApplication();
        
        app.Run();
    }
}