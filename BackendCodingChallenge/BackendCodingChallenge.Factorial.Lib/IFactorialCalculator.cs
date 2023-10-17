using System.Numerics;

namespace BackendCodingChallenge.Factorial.Lib;

/// <summary>
/// Calculator used to determine the factorial of a number. The factorial is expressed as a <see cref="BigInteger"/> to prevent
/// overflow.
/// </summary>
public interface IFactorialCalculator
{
    /// <summary>
    /// Calculates the factorial of the specified integer.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    BigInteger Calculate(int number);
}