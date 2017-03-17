using System;

namespace FloatOrInteger
{
    class Program
    {
        public static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            if (number is int)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }

        }
    }
}
