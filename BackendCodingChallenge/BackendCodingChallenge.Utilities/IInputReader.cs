namespace BackendCodingChallenge.Utilities;

/// <summary>
/// Type used to read a string from an input source.
/// </summary>
public interface IInputReader
{
    /// <summary>
    /// Reads a string from the input source.
    /// </summary>
    /// <returns>A result containing the input string or a problem message if an error occurred</returns>
    Result<string?> Read();
}