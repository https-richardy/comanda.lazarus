namespace Comanda.Establishment.CrossCutting.Configuration;

public sealed class Settings : ISettings
{
    public DatabaseSettings Database { get; init; } = default!;
}