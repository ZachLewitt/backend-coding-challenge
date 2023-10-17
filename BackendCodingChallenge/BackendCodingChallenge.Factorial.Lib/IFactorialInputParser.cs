using BackendCodingChallenge.Utilities;

namespace BackendCodingChallenge.Factorial.Lib;

public interface IFactorialInputParser
{
    Result<int> Parse(string? rawValue);
}