namespace BackendCodingChallenge.Utilities;

/// <summary>
/// Type used to communicate the result of an operation. It encapsulates either a successful operation which has returned
/// a result object or a failed operation and the reason for the failure.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="Success">Whether the operation was successful or not</param>
/// <param name="Obj">The object containing the data returned from the operation if it was successful</param>
/// <param name="Problem">Message describing the problem that caused the operation to fail</param>
public record Result<T>(bool Success, T? Obj, string Problem)
{
    public static Result<T> Ok(T obj)
    {
        return new Result<T>(true, obj, string.Empty);
    }

    public static Result<T> Fail(string problem)
    {
        return new Result<T>(false, default, problem);
    }
};
