namespace Comanda.Establishment.Infrastructure.IoC.Extensions;

[ExcludeFromCodeCoverage]
public static class MediatorExtension
{
    public static void AddMediator(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(CreateEstablishmentCommand).Assembly);
        });
    }
}