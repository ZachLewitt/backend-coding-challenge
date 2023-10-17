namespace BackendCodingChallenge.Factorial.Lib;

public class FactorialCalculator : IFactorialCalculator
{
    public int Calculate(int number)
    {
        if (number == 0) 
            return 1;

        var factorial = Enumerable.Range(1, number).Aggregate(1, (current, item) => current * item);

        return factorial;
    }
}