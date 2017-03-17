using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());

            var contains = false;


            for (int i = 0; i < array.Length; i++)
            {



                if (array[i] == n)
                {

                    contains = true;
                    break;
                }

            }
            if (contains)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");


            }
        }
    }
}
