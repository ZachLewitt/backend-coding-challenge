using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

/// <summary>
/// Rules used by the <see cref="FizzBuzzEngine"/> to check if an int value is a number that
/// it can match and process. If it matches then the rule returns a string interpretation of
/// the value.
/// </summary>
public interface IFizzBuzzRule
{
    /// <summary>
    /// The rules priority order against other rules. The application configures this priority order.
    /// </summary>
    int Priority { get; }

    /// <summary>
    /// Checks if the integer matches the rule and returns a string interpretation of the value if it
    /// does.
    /// </summary>
    /// <param name="value">The value to check</param>
    /// <returns>Result containing either the string interpretation or a reason why it didn't match</returns>
    public Result<string> Run(int value);
}
