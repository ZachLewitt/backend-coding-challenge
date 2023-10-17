using BackendCodingChallenge.FizzBuzz.Lib;

namespace BackendCodingChallenge.FizzBuzz.Tests;

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