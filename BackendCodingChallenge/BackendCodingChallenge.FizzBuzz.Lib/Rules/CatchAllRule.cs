namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

public class CatchAllRule : IFizzBuzzRule
{
    public int Priority { get; }

    public CatchAllRule(int priority)
    {
        Priority = priority;
    }

    public string Run(int value)
    {
        return value.ToString();
    }
}

