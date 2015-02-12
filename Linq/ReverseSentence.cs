using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ReverseSentence
    {
        public static string Reverse(string input)
        {
            return input.Split(' ').Aggregate((a, b) => b + " " + a);
        }
    }
}
