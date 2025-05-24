namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class ConfigurationExtension
{
    public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<Settings>(configuration);
        services.AddSingleton<ISettings>(provider =>
            provider.GetRequiredService<IOptions<Settings>>().Value
        );
    }
}