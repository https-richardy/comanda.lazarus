namespace Comanda.Contracts.Results;

public sealed class OperationResult<TData> : OperationResult
{
    public TData? Data { get; }

    private OperationResult(TData data)
        : base(true, Error.None)
    {
        Data = data;
    }

    private OperationResult(Error error)
        : base(false, error)
    {
        Data = default;
    }

    public static OperationResult<TData> Success(TData data) => new(data);
    public static new OperationResult<TData> Failure(Error error) => new(error);
}
