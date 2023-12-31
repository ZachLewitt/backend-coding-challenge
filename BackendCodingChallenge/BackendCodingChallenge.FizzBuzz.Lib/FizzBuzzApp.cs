﻿namespace BackendCodingChallenge.FizzBuzz.Lib;

/// <summary>
/// The FizzBuzzApp uses the <see cref="FizzBuzzEngine"/> to process the numbers 1 to 100 and generate the
/// expected FizzBuzz output.
/// </summary>
public class FizzBuzzApp
{
    private readonly FizzBuzzEngine _engine;

    public FizzBuzzApp(FizzBuzzEngine engine)
    {
        _engine = engine;
    }

    public void Run()
    {
        // Process the result for the numbers 1 to 100.
        var values = Enumerable.Range(1, 100);

        foreach (var value in values)
        { 
            _engine.Process(value);
        }
    }
}