using BackendCodingChallenge.FizzBuzz.Lib;
using BackendCodingChallenge.FizzBuzz.Lib.Rules;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class FizzBuzzServiceCollectionExtensions
{
    private const string FizzBuzz = "FizzBuzz";

    private const string Fizz = "Fizz";

    private const string Buzz = "Buzz";

    /// <summary>
    /// Adds the services that are needed to run the FizzBuzz application.
    /// </summary>
    /// <param name="services"></param>
    public static void AddFizzBuzzServices(this IServiceCollection services)
    {
        services.AddSharedUtilities();

        services.AddSingleton<FizzBuzzApp>();
        services.AddTransient<FizzBuzzEngine>();

        // Register the FizzBuzz rules assigning the correct priorities. The CatchAllRule must have the lowest priority.
        services.AddTransient<IFizzBuzzRule>(_ => new MultipleMatchRule(1, new[] { 3, 5 }, FizzBuzz));
        services.AddTransient<IFizzBuzzRule>(_ => new SingleMatchRule(2, 3, Fizz));
        services.AddTransient<IFizzBuzzRule>(_ => new SingleMatchRule(3, 5, Buzz));
        services.AddTransient<IFizzBuzzRule>(_ => new CatchAllRule(4));
    }
}