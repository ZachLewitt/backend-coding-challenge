using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Lib;

/// <summary>
/// Parser used to convert the raw input value to an integer that can be used to calculate the
/// factorial.
/// </summary>
public interface IFactorialInputParser
{
    /// <summary>
    /// Tries to parse the string to an integer.
    /// </summary>
    /// <param name="rawValue">The raw input value from the user</param>
    /// <returns>Result containing either the parsed integer or the reason why it couldn't be parsed</returns>
    Result<int> Parse(string? rawValue);
}