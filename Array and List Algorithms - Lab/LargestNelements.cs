using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNelements
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();
            var largestElement = new List<int>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                largestElement.Add(list[i]);



            }
            Console.WriteLine(String.Join(" ", largestElement));
        }
    }
}
