namespace BackendCodingChallenge.FizzBuzz.Lib;

public class ConsoleOutputWriter : IOutputWriter
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}