using System.Numerics;

namespace BackendCodingChallenge.Factorial.Lib;

public class FactorialCalculator : IFactorialCalculator
{
    public BigInteger Calculate(int number)
    {
        if (number == 0) 
            return 1;

        var factorial = Enumerable.Range(1, number).Aggregate(new BigInteger(1), (current, item) => current * item);

        return factorial;
    }
}