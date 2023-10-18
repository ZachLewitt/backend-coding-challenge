namespace BackendCodingChallenge.Utilities;

/// <summary>
/// Type used to write a message to an output source.
/// </summary>
public interface IOutputWriter
{
    /// <summary>
    /// Writes the message to the output source.
    /// </summary>
    /// <param name="message">The message to output</param>
    void Write(string message);
}