using BackendCodingChallenge.Factorial.Lib;
using BackendCodingChallenge.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BackendCodingChallenge.Factorial.Tests;

[Binding]
public class FactorialSteps
{
    private readonly FactorialContext _context;

    public FactorialSteps(FactorialContext context)
    {
        _context = context;
    }

    [Given("the user has entered (.*)")]
    public void GivenTheUserHasEntered(string input)
    {
        _context.Input = input;
    }

    [Given("an error will occur when the user tries to submit the value")]
    public void GivenAnErrorWillOccurWhenTheUserTriesToSubmitValue()
    {
        _context.HasReadErrorOccurred = true;
    }

    [Given("the user does not enter a value")]
    public void GivenTheUserDoesNotEnterAValue()
    {
        _context.Input = null;
    }

    [When("the user submits the value")]
    [When("the user quits the application")]
    public void WhenTheUserSubmitsTheValue()
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Services.AddFactorialServices();

        builder.Services.AddSingleton(_context);
        builder.Services.AddTransient<IOutputWriter, FakeOutputWriter>();
        builder.Services.AddTransient<IInputReader, FakeInputReader>();

        using var host = builder.Build();
        using var scope = host.Services.CreateScope();

        var app = scope.ServiceProvider.GetRequiredService<FactorialApp>();

        app.Run();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(string expectedResult)
    {
        Assert.That(_context.OutputMessages, Contains.Item($"The factorial is: '{expectedResult}'"));
    }

    [Then("the user should be shown the error '(.*)'")]
    public void ThenTheUserShouldBeShownTheError(string error)
    {
        Assert.That(_context.OutputMessages, Contains.Item(error));
    }
}