using FinSpect.Application.Common.Interfaces.Repository;
using FinSpect.Application.Common.Interfaces.Services;
using FinSpect.Application.Common.Repository;
using FinSpect.Application.Common.Services;

namespace FinSpect.Api.Configuration.DI;

public static class Services
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        //Repository
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        //Services
        services.AddScoped<ITransactionService, TransactionService >();
        return services;
    }
}