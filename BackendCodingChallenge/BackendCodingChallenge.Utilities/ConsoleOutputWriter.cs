namespace BackendCodingChallenge.Utilities;

/// <summary>
/// Type used to write a message to the console.
/// </summary>
public class ConsoleOutputWriter : IOutputWriter
{
    /// <summary>
    /// Writes the message to the console.
    /// </summary>
    /// <param name="message">The message to output</param>
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}