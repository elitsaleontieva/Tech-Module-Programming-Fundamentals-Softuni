using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');

          
            var numbers = strings.Select(int.Parse).ToList().OrderByDescending(x => x).Take(3);
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
