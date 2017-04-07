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

            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2!=0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
