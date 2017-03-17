
using System;

namespace ExactProductOfRealNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            double product = 0;

            for (int i = 0; i < n; i++)
                product *= double.Parse(Console.ReadLine());

            Console.WriteLine(product);
        }
    }
}
   
