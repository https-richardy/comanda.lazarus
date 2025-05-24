namespace Comanda.Establishment.CrossCutting.Configuration;

public sealed record DatabaseSettings
{
    public string ConnectionString { get; set; } = default!;
}