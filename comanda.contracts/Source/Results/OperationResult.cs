namespace Comanda.Contracts.Results;

public class OperationResult
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;

    public Error Error { get; }

    protected OperationResult(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public static OperationResult Success() => new(true, Error.None);
    public static OperationResult Failure(Error error)
    {
        if (error == null || error == Error.None)
            throw new ArgumentException("Invalid error for failure.", nameof(error));

        return new OperationResult(false, error);
    }
}
