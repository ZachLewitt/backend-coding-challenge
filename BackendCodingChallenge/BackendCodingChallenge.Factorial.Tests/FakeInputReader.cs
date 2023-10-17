using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Tests;

public class FakeInputReader : IInputReader
{
    private readonly FactorialContext _context;

    public FakeInputReader(FactorialContext context)
    {
        _context = context;
    }

    public Result<string?> Read()
    {
        if(_context.HasReadErrorOccurred)
            return Result<string?>.Fail("An error occurred reading the users input");

        return Result<string?>.Ok(_context.Input);
    }
}