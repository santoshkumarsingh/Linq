using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DuplicateFiles
    {
        public static void FindDuplicateFiles(string path)
        {

            //Locating exact-duplicate files
            var dupilcateFiles = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
                          .Where(d => d.EndsWith(".txt"))
                          .Select(d => new { FileName = d, ContentHash = File.ReadAllText(d).GetHashCode() })
                          .ToLookup(d => d.ContentHash)
                          .Where(d => d.Count() >= 2);
            foreach (var files in dupilcateFiles)
            {
                foreach (var item in files)
                {
                    Console.WriteLine(item.FileName);
                }
            }

        }
    }
}
