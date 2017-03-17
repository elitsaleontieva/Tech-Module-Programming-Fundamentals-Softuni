using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumberss
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            var count = 0;
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;


                }
                else
                {
                    counts[num] = 1;
                }





            }

            foreach (var i in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", i, counts[i]);


            }
        }
    }
}
