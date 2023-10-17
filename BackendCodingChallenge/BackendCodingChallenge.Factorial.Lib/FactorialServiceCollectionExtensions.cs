using BackendCodingChallenge.Factorial.Lib;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class FactorialServiceCollectionExtensions
{
    public static void AddFactorialServices(this IServiceCollection services)
    {
        services.AddSharedUtilities();

        services.AddSingleton<FactorialApp>();
        services.AddTransient<IFactorialInputParser, FactorialInputParser>();
        services.AddTransient<IFactorialCalculator, FactorialCalculator>();
    }
}