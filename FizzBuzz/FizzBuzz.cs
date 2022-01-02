using System.Collections.Generic;

namespace FizzBuzz;

public class FizzBuzz
{

    public IList<string> GetFizzBuzz()
    {
        var result = new List<string>();
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }
        return result;
    }
}