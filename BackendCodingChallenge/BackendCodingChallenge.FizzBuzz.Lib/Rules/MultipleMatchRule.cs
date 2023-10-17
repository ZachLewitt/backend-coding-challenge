using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCodingChallenge.FizzBuzz.Lib.Rules;

public class MultipleMatchRule : IFizzBuzzRule
{
    public int Priority { get; }

    private readonly int[] _multiples;

    private readonly string _valueToReturn;

    public MultipleMatchRule(int Priority, int[] multiples, string valueToReturn)
    {
        Priority = Priority;

        _multiples = multiples;
        _valueToReturn = valueToReturn;
    }

    public string? Run(int value)
    {
        var areMatches = _multiples.All(x => value % x == 0);

        return areMatches ? _valueToReturn : null;
    }
}