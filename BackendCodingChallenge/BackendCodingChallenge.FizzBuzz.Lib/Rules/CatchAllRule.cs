using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

/// <summary>
/// FizzBuzz rule used as a catch all for if more specific rules do not match. This rule will
/// always match and will return the value as a string.
/// </summary>
public class CatchAllRule : IFizzBuzzRule
{
    public int Priority { get; }

    public CatchAllRule(int priority)
    {
        Priority = priority;
    }

    public Result<string> Run(int value)
    {
        return Result<string>.Ok(value.ToString());
    }
}

