using System.Linq;
using FizzBuzz;

// See https://aka.ms/new-console-template for more information

var fizzBuzz = new FizzBuzzSeries();
Console.WriteLine(fizzBuzz.GetFizzBuzz().Aggregate((a, b) => a + "\n" + b));
