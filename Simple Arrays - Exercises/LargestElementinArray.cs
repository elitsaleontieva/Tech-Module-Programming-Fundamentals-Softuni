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
            var stringArray = int.Parse(Console.ReadLine());
            var array = new int[stringArray];

            var largestElement = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] > largestElement)
                {
                    largestElement = array[i];
                   
                }

            }
            Console.WriteLine(largestElement);

        }
    }
}
