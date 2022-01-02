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

    
}
