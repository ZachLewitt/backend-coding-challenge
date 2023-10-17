using BackendCodingChallenge.FizzBuzz.Lib;
using BackendCodingChallenge.FizzBuzz.Lib.Rules;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class FizzBuzzServiceCollectionExtensions
{
    private const string FizzBuzz = "FizzBuzz";

    private const string Fizz = "Fizz";

    private const string Buzz = "Buzz";

    public static void AddFizzBuzzServices(this IServiceCollection services)
    {
        services.AddSingleton<FizzBuzzApp>();
        services.AddTransient<FizzBuzzEngine>();
        services.AddTransient<IOutputWriter, ConsoleOutputWriter>();

        services.AddTransient<IFizzBuzzRule>(_ => new MultipleMatchRule(1, new[] { 3, 5 }, FizzBuzz));
        services.AddTransient<IFizzBuzzRule>(_ => new SingleMatchRule(2, 3, Fizz));
        services.AddTransient<IFizzBuzzRule>(_ => new SingleMatchRule(3, 5, Buzz));
        services.AddTransient<IFizzBuzzRule>(_ => new CatchAllRule(4));
    }
}