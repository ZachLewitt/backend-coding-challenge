using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Tests;

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