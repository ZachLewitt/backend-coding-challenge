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
    public void GivenTheUserHasEntered(int number)
    {
        _context.NumberOfItems = number;
    }

    [When("the factorial is calculated")]
    public void WhenTheFactorialIsCalculated()
    {
        // Execute application
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expectedResult)
    {
        Assert.That(_context.Result, Is.EqualTo(expectedResult));
    }
}