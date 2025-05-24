namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class ServicesExtension
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers()
            .AddJsonOptions(options =>
            {
                // the following line is added to prevent issues related to circular references
                // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

        services.AddOpenApi();
        services.AddConfiguration(configuration);
        services.AddValidation();
        services.AddMediator();
    }
}