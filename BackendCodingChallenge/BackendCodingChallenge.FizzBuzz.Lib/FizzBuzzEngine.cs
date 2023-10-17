using BackendCodingChallenge.FizzBuzz.Lib.Rules;

namespace BackendCodingChallenge.FizzBuzz.Lib;

public class FizzBuzzEngine
{
    private readonly IReadOnlyList<IFizzBuzzRule> _rules;

    private readonly IOutputWriter _outputWriter;

    public FizzBuzzEngine(IEnumerable<IFizzBuzzRule> rules, IOutputWriter outputWriter)
    {
        _rules = rules.OrderBy(x => x.Priority).ToList();
        _outputWriter = outputWriter;
    }

    public void Process(int value)
    {
        string? result = null;

        foreach (var rule in _rules)
        {
            result = rule.Run(value);

            if (result != null)
                break;
        }

        if (result == null)
            throw new InvalidOperationException(
                $"The {nameof(IFizzBuzzRule)} have been configured incorrectly for the application");

        _outputWriter.Write(result);
    }
}