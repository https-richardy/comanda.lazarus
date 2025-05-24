namespace Comanda.Establishment.CrossCutting.Configuration;

public interface ISettings
{
    DatabaseSettings Database { get; }
}