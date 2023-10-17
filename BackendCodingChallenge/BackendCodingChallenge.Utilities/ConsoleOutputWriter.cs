namespace BackendCodingChallenge.Utilities;

public class ConsoleOutputWriter : IOutputWriter
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}