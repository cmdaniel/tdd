using System.Linq;

namespace FizzBuzz;

// See https://aka.ms/new-console-template for more information
public static class Program
{
    public static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzz();
        Console.WriteLine(fizzBuzz.GetFizzBuzz().Aggregate((a, b) => a + "\n" + b));
    }
}
// </SnippetProgram>
