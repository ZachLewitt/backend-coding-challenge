using TechTalk.SpecFlow;

namespace BackendCodingChallenge.Factorial.Tests;

[Binding]
public class FactorialContext
{
    public int? NumberOfItems { get; set; }

    public int? Result { get; set; }
}