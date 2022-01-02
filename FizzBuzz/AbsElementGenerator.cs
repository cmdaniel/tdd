using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public abstract class AbsElementGenerator
    {
        public abstract string GetElement(int i);
    }
}