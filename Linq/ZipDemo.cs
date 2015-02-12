using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ZipDemo
    {
        public static string[] firtNames = new[] { "Bill", "Barak" };
        public static string[] lastNames = new[] { "Gates", "Obama" };
        public static string[] FullNames()
        {

            return firtNames.Zip(lastNames, (f, l) => f + " " + l).ToArray();
        }
    }
}
