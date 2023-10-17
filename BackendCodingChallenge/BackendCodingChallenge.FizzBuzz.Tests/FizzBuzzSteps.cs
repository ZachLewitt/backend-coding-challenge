using BackendCodingChallenge.FizzBuzz.Lib;
using BackendCodingChallenge.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BackendCodingChallenge.FizzBuzz.Tests;

[Binding]
public class FizzBuzzSteps
{
    private readonly FizzBuzzContext _context;

    public FizzBuzzSteps(FizzBuzzContext context)
    {
        _context = context;
    }

    [Given("the input number is (.*)")]
    public void GivenTheInputNumberIs(int number)
    {
        _context.InputNumber = number;
    }

    [When("the number is processed")]
    public void WhenTheNumberIsProcessed()
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Services.AddFizzBuzzServices();

        builder.Services.AddSingleton(_context);
        builder.Services.AddTransient<IOutputWriter, FakeOutputWriter>();

        using var host = builder.Build();
        using var scope = host.Services.CreateScope();

        var engine = scope.ServiceProvider.GetRequiredService<FizzBuzzEngine>();

        engine.Process(_context.InputNumber);
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(string expectedResult)
    {
        Assert.That(_context.Result, Is.EqualTo(expectedResult));
    }
}