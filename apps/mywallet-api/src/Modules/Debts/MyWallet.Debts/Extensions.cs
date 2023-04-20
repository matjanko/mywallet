using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using MyWallet.Debts.DAL;
using MyWallet.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("MyWallet.Api")]
namespace MyWallet.Debts;

internal static class Extensions
{
    public static IServiceCollection AddDebts(this IServiceCollection services)
    {
        services.AddScoped<DebtsDbContext>();
        services.AddPostgres<DebtsDbContext>();
        return services;
    }
}
