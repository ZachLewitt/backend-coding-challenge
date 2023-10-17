using TechTalk.SpecFlow;

namespace BackendCodingChallenge.FizzBuzz.Tests;

[Binding]
public class FizzBuzzContext
{
    public int? InputNumber { get; set; }

    public string? Result { get; set; }
}