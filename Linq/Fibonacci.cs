using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Fibonacci
    {
        public static IEnumerable<int> Fib(int n)
        {
            List<int> fibs = new List<int>();
            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibs.Add((f <= 1 ? 1 : fibs[f - 2] + fibs[f - 1])));
            return fibs;


        }
    }
}
