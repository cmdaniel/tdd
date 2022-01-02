using System.Collections.Generic;
using FizzBuzz.Generator;

namespace FizzBuzz;

public class FizzBuzzSeries
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
