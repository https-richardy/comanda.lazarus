namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class ValidationExtension
{
    public static void AddValidation(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(configuration =>
        {
            configuration.DisableDataAnnotationsValidation = true;
        });
    }
}