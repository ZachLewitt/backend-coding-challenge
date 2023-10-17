using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Tests;

/// <summary>
/// Fake output writer used to capture the data output by the application to assert against in the Then
/// steps.
/// </summary>
public class FakeOutputWriter : IOutputWriter
{
    private readonly FactorialContext _context;

    public FakeOutputWriter(FactorialContext context)
    {
        _context = context;
    }

    public void Write(string message)
    {
        _context.OutputMessages.Add(message);
    }
}