namespace BackendCodingChallenge.Utilities;

/// <summary>
/// Type used to read user input from the console.
/// </summary>
public class ConsoleInputReader : IInputReader
{
    /// <summary>
    /// Reads a line of text from the console.
    /// </summary>
    /// <returns>A result containing either the text or a problem message if an error occurred</returns>
    public Result<string?> Read()
    {
        Result<string?> result;

        try
        {
            var value = Console.ReadLine();

            result = Result<string?>.Ok(value);
        }
        catch (Exception e)
        {
            result = Result<string?>.Fail($"Unable to read input due to: '{e.Message}'");
        }

        return result;
    }
}