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
        // Execute application
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(string expectedResult)
    {
        Assert.That(_context.Result, Is.EqualTo(expectedResult));
    }
}