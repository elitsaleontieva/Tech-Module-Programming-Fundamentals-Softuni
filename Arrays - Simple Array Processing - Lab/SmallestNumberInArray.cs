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
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int smallestNumber = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                   
                }

            }
            Console.WriteLine(smallestNumber);

        }
    }
}
