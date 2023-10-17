using BackendCodingChallenge.Factorial.Lib;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class FactorialServiceCollectionExtensions
{
    /// <summary>
    /// Adds the services that are needed to run the Factorial application.
    /// </summary>
    /// <param name="services"></param>
    public static void AddFactorialServices(this IServiceCollection services)
    {
        services.AddSharedUtilities();

        services.AddSingleton<FactorialApp>();
        services.AddTransient<IFactorialInputParser, FactorialInputParser>();
        services.AddTransient<IFactorialCalculator, FactorialCalculator>();
    }
}