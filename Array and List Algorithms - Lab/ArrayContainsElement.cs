using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            var element = Console.ReadLine();

            var isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    isFound = true;
                }
              
            }
            if (isFound == true)
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
