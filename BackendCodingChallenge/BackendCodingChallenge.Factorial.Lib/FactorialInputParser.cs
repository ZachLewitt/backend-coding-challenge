using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Lib;

/// <inheritdoc cref="IFactorialInputParser"/>
public class FactorialInputParser : IFactorialInputParser
{
    public Result<int> Parse(string? rawValue)
    {
        if (string.IsNullOrWhiteSpace(rawValue))
            return Result<int>.Fail("No value has been provided. The value must be a positive integer.");

        if (!int.TryParse(rawValue, out var number))
            return Result<int>.Fail("The supplied value is not a valid integer. The value must be a positive integer.");

        if (number < 0)
            return Result<int>.Fail("The supplied value is less than zero. The value must be a positive integer.");

        return Result<int>.Ok(number);
    }
}
