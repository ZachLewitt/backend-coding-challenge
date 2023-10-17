using BackendCodingChallenge.Utilities;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class UtilitiesServiceCollectionExtensions
{
    /// <summary>
    /// Registers the utility types that are shared across the applications in the solution.
    /// </summary>
    /// <param name="services"></param>
    public static void AddSharedUtilities(this IServiceCollection services)
    {
        services.AddTransient<IOutputWriter, ConsoleOutputWriter>();
        services.AddTransient<IInputReader, ConsoleInputReader>();
    }
}