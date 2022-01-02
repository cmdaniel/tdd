using NUnit.Framework;

namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldHave100Items()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz();
        Assert.Equals(100, result.Count);
    }

    [Test]
    public void ShouldHaveThridItemFizz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz();
        Assert.Equals("Fizz", result[2]);
    }

    public void ShouldHaveFifthItemBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz();
        Assert.Equals("Buzz", result[4]);
    }

    [Test]
    public void ShouldHaveFifteenItemFizzBuzz()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.GetFizzBuzz();
        Assert.Equals("FizzBuzz", result[14]);
    }


}
