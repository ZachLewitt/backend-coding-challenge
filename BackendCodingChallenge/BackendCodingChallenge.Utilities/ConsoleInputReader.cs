namespace BackendCodingChallenge.Utilities;

public class ConsoleInputReader : IInputReader
{
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