using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
   public class Factorial
    {
       public static long FactorialLinq(int n)
       {
           return Enumerable.Range(1, n)
                .Aggregate(1, (x, y) => x * y);

       }
    }
}
