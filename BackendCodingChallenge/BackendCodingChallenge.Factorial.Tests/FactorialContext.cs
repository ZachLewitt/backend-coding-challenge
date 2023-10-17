using TechTalk.SpecFlow;

namespace BackendCodingChallenge.Factorial.Tests;

[Binding]
public class FactorialContext
{
    /// <summary>
    /// Represents the value that the user has input into the application.
    /// </summary>
    public string? Input { get; set; }

    /// <summary>
    /// Flag used by the fakes to determine whether to return an error from the reader.
    /// </summary>
    public bool HasReadErrorOccurred { get; set; } = false;

    /// <summary>
    /// The messages that the application has output to the user.
    /// </summary>
    public List<string> OutputMessages { get; } = new();
}