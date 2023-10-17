using TechTalk.SpecFlow;

namespace BackendCodingChallenge.FizzBuzz.Tests;

/// <summary>
/// Test context used to store the test state for the FizzBuzz tests.
/// </summary>
[Binding]
public class FizzBuzzContext
{
    /// <summary>
    /// The number to input into the FizzBuzz application.
    /// </summary>
    public int InputNumber { get; set; } = 1;

    /// <summary>
    /// The result output by the application during the test run.
    /// </summary>
    public string? Result { get; set; }
}