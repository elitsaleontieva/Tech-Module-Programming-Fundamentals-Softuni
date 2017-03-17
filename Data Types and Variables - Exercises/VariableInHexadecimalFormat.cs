using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        public static void Main(string[] args)
        {

            string hex = Console.ReadLine();


            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
