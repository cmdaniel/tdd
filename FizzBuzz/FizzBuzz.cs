using System.Collections.Generic;

namespace FizzBuzz;

public class FizzBuzz
{

    public IList<string> GetFizzBuzz(Int16 numOfElements = 100)
    {
        var result = new List<string>();
        result = Enumerable.Range(1, numOfElements)
            .Select(i => GeneratorFactory.GetGenerator(i).GetElement(i))
            .Cast<string>()
            .ToList();
        return result;
    }
}