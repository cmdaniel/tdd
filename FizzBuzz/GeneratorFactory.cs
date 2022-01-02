using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class GeneratorFactory
    {
        public static AbsElementGenerator GetGenerator(int i) {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return new FizzBuzzGenerator();
            }
            else if (i % 3 == 0)
            {
                return new FizzGenerator();
            }
            else if (i % 5 == 0)
            {
                return new BuzzGenerator();
            }
            else
            {
                return new NumberGenerator();
            }
        }
    }
}