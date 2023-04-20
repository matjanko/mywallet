using System.Runtime.CompilerServices;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("MyWallet.Api")]
namespace MyWallet.Infrastructure;

internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    { 
        services.AddControllers();
        services.AddFastEndpoints();
        services.AddSwaggerDoc();
        return services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseAuthorization();
        app.UseFastEndpoints(c =>
        {
            c.Endpoints.RoutePrefix = "api";
        });
        app.UseOpenApi();
        app.UseSwaggerUi3(c =>
        {
            c.ConfigureDefaults();
            c.Path = "/api";
        });
        return app;
    }
}
