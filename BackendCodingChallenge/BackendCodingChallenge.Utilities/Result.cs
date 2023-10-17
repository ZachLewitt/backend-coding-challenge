namespace BackendCodingChallenge.Utilities;

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
