using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWallet.Infrastructure.Options;

namespace MyWallet.Infrastructure.Postgres;

public static class Extensions
{
    public static IServiceCollection AddPostgres<TContext>(this IServiceCollection services)
        where TContext : DbContext
    {
        var options = services.GetOptions<PostgresOptions>(PostgresOptions.Postgres);
        services.AddDbContext<TContext>(c =>
        {
            c.UseNpgsql(options.ConnectionString);
        });
        
        var provider = services.BuildServiceProvider();
        var environment = provider.GetRequiredService<IWebHostEnvironment>();

        if (environment.IsDevelopment())
        {
            var context = provider.GetRequiredService<TContext>();
            context.Database.Migrate();
        }
        return services;
    }
}
