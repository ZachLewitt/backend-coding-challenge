namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

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

    public string? Run(int value)
    {
        var isMatch = value % _multiple == 0;

        return isMatch ? _valueToReturn : null;
    }
}