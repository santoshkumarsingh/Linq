﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber.GeneratePrimeNumber(100);
            Currency.Solve();
            Console.WriteLine(CeaserCipher.Encrypt("abc adafda", 3)); ;
            Console.WriteLine(CeaserCipher.Decrypt(CeaserCipher.Encrypt("abc adafda", 3), 3));
            foreach (var item in ZipDemo.FullNames())
            {
                Console.WriteLine(item);
            }
            DuplicateFiles.FindDuplicateFiles(@"C:\users\santosh\downloads");
            Console.WriteLine(ReverseSentence.Reverse("singh kumar santosh "));
            Console.WriteLine(Factorial.FactorialLinq(4));

          
        }
    }
}
