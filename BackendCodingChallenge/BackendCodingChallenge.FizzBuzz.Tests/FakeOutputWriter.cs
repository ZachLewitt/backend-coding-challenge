using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.FizzBuzz.Tests;

/// <summary>
/// Fake output writer used to capture the data output by the application to assert against in the Then
/// steps.
/// </summary>
public class FakeOutputWriter : IOutputWriter
{
    private readonly FizzBuzzContext _context;

    public FakeOutputWriter(FizzBuzzContext context)
    {
        _context = context;
    }

    public void Write(string message)
    {
        _context.Result = message;
    }
}