namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class CorsConfigurationExtension
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });
        });
    }
}