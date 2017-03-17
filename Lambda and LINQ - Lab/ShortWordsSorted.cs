using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
  {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            var list = Console.ReadLine().ToLower()
                .Split(separators)
                .ToArray()
                .Distinct()
                .OrderBy(x => x).
                Where(l => l != "")
                .Where(c => c.Length<5);

            Console.WriteLine(String.Join(", ", list));



        }
    }
}
       