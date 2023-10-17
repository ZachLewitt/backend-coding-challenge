using System.Numerics;

namespace BackendCodingChallenge.Factorial.Lib;

/// <inheritdoc cref="IFactorialCalculator"/>
public class FactorialCalculator : IFactorialCalculator
{
    public BigInteger Calculate(int number)
    {
        // Return early if the number is 0 so that it doesn't interfere with the calculation that follows.
        if (number == 0) 
            return 1;

        var factorial = Enumerable.Range(1, number).Aggregate(new BigInteger(1), (current, item) => current * item);

        return factorial;
    }
}