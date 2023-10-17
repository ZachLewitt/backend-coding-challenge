namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

public interface IFizzBuzzRule
{
    int Priority { get; }

    public string? Run(int value);
}
