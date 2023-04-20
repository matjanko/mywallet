using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyWallet.Infrastructure.Options;

internal static class Extensions
{
    public static T GetOptions<T>(this IServiceCollection services, string key) where T : new()
    {
        var options = new T();
        
        using var providers = services.BuildServiceProvider();
        var configuration = providers.GetRequiredService<IConfiguration>();
        configuration.GetSection(key).Bind(options);
        return options;
    }
}
