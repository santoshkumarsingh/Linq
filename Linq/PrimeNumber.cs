using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    public class PrimeNumber
    {
        public static IEnumerable<int> GeneratePrimeNumber(int p)
        {
            var primes = Enumerable.Range(3, 100)
                            .Where(n => Enumerable.Range(2, n / 2)
                            .All(i => n % i != 0));

            return primes;
        }
    }
}
