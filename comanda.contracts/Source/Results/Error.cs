namespace Comanda.Contracts.Results;

public sealed record Error(string Code, string Message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error Unknown = new("Unknown", "An unknown error has occurred.");
}
