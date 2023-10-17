using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

/// <summary>
/// FizzBuzz rule that requires the value to be a multiple of all the specified integers
/// in order to match and return a success result.
/// </summary>
public class MultipleMatchRule : IFizzBuzzRule
{
    public int Priority { get; }

    private readonly int[] _multiples;

    private readonly string _valueToReturn;

    public MultipleMatchRule(int priority, int[] multiples, string valueToReturn)
    {
        Priority = priority;

        _multiples = multiples;
        _valueToReturn = valueToReturn;
    }

    public Result<string> Run(int value)
    {
        var areMatches = _multiples.All(x => value % x == 0);

        return areMatches
            ? Result<string>.Ok(_valueToReturn)
            : Result<string>.Fail(
                $"{value} is not a multiple of all of the following: {string.Join(", ", _multiples)}");
    }
}