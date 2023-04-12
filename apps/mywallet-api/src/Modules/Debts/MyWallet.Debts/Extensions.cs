using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("MyWallet.Api")]
namespace MyWallet.Debts;

internal static class Extensions
{
    public static IServiceCollection AddDebts(this IServiceCollection services)
    {
        return services;
    }
}