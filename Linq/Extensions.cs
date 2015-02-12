using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Extensions
    {
        public static void Dump(this IEnumerable<object> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        public static void Dump(this string input)
        {
            Console.WriteLine(input);
        }
    }
}
