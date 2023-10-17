using System.Numerics;

namespace BackendCodingChallenge.Factorial.Lib;

public interface IFactorialCalculator
{
    BigInteger Calculate(int number);
}