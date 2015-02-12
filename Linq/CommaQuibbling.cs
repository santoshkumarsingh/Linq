using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class CommaQuibbling
    {
        public static string CommaQuibblingString(string[] input)
        {

            string result =
            "{" //starting/opening brace
            + input.Take(input.Length - 1).Aggregate((f, s) => f + ", " + s)
            + " and "
            + input.Last()
            + "}";//closing brace
            return result;
        }
    }
}
