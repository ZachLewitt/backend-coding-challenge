using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Lib;

/// <summary>
/// The FactorialApp requests a number from the user and then generates the factorial for it. The factorial is then displayed
/// to the user.
/// </summary>
public class FactorialApp
{
    private readonly IFactorialInputParser _inputParser;

    private readonly IOutputWriter _outputWriter;

    private readonly IInputReader _inputReader;

    private readonly IFactorialCalculator _calculator;

    public FactorialApp(
        IFactorialInputParser inputParser,
        IOutputWriter outputWriter,
        IInputReader inputReader,
        IFactorialCalculator calculator)
    {
        _inputParser = inputParser;
        _outputWriter = outputWriter;
        _inputReader = inputReader;
        _calculator = calculator;
    }

    public void Run()
    {
        _outputWriter.Write("Enter a number to calculate the factorial:");

        var (readResult, rawValue, readProblem) = _inputReader.Read();
        if (!readResult)
        {
            _outputWriter.Write(readProblem);
            return;
        }

        var (parseSuccess, number, parseProblem) = _inputParser.Parse(rawValue);
        if (!parseSuccess)
        {
            _outputWriter.Write(parseProblem);
            return;
        }

        var factorial = _calculator.Calculate(number);

        _outputWriter.Write($"The factorial is: '{factorial}'");
    }
}