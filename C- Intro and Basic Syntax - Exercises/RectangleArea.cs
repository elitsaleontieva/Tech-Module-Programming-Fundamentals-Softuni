using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var num1 =double.Parse(Console.ReadLine());
            var num2= double.Parse(Console.ReadLine());

            var result = num1 * num2;
            Console.WriteLine($"{result:F2}");
            

        }
    }
}
