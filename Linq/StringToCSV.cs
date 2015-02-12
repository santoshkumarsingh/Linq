using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class StringToCSV
    {
        public static string ToCSV(string[] input)
        {
            var joinedString = input.Aggregate("", (a, b) => a + "," + b).Remove(0, 1);

            return joinedString;
        }
    }
}
