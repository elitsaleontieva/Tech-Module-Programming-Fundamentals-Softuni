using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var n = double.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= n;

            }
            Console.WriteLine(String.Join(" ",array));

        }
    }
}
