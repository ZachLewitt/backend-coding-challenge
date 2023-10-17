using BackendCodingChallenge.FizzBuzz.Lib.Rules;
using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Lib;

/// <summary>
/// Engine used to check an integer value against a set of rules that generate string representations of the
/// value if they match.
/// </summary>
public class FizzBuzzEngine
{
    private readonly IReadOnlyList<IFizzBuzzRule> _rules;

    private readonly IOutputWriter _outputWriter;

    public FizzBuzzEngine(IEnumerable<IFizzBuzzRule> rules, IOutputWriter outputWriter)
    {
        // Order the rules so that they run in priority order.
        _rules = rules.OrderBy(x => x.Priority).ToList();
        _outputWriter = outputWriter;
    }

    public void Process(int value)
    {
        Result<string>? result = null;

        foreach (var rule in _rules)
        {
            result = rule.Run(value);

            if (result.Success)
                break;
        }

        // If there is no match then the rules have been misconfigured in the service registration code. Throw an
        // exception here to alert the developer to the fact that something is broken and needs updating.
        if (result == null || !result.Success)
            throw new InvalidOperationException(
                $"The {nameof(IFizzBuzzRule)} have been configured incorrectly for the application");

        _outputWriter.Write(result.Obj!);
    }
}