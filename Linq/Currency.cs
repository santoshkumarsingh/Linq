using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Currency
    {
        public static Dictionary<int, int> Solve()
        {
            int[] curvals = { 500, 100, 50, 20, 10, 5, 2, 1, 1000 };
            int amount = 11;
            Dictionary<int, int> map = new Dictionary<int, int>();
            curvals.OrderByDescending(c => c)
                   .ToList()
                   .ForEach(c =>
                   {
                       map.Add(c, amount / c); amount = amount % c;
                   }

                       );

            //return map.Where(m => m.Value != 0);
            return map;

        }
    }
}
