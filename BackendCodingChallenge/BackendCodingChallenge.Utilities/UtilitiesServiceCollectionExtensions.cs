using BackendCodingChallenge.Utilities;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class UtilitiesServiceCollectionExtensions
{
    public static void AddSharedUtilities(this IServiceCollection services)
    {
        services.AddTransient<IOutputWriter, ConsoleOutputWriter>();
        services.AddTransient<IInputReader, ConsoleInputReader>();
    }
}