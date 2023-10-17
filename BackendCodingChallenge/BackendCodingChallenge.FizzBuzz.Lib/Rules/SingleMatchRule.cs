using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

/// <summary>
/// FizzBuzz rule that requires the value to be a multiple of the specified integer in order to match
/// and return a success result.
/// </summary>
public class SingleMatchRule : IFizzBuzzRule
{
    public int Priority { get; }

    private readonly int _multiple;

    private readonly string _valueToReturn;

    public SingleMatchRule(int priority, int multiple, string valueToReturn)
    {
        Priority = priority;

        _multiple = multiple;
        _valueToReturn = valueToReturn;
    }

    public Result<string> Run(int value)
    {
        var isMatch = value % _multiple == 0;

        return isMatch
            ? Result<string>.Ok(_valueToReturn)
            : Result<string>.Fail($"{value} is not a multiple of {_multiple}");
    }
}