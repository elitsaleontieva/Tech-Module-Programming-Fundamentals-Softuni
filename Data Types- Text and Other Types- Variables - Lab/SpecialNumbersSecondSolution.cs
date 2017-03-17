
using System;

namespace SpecialNumbersSecondSolution
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
		
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int number = num;
		    
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", num, special);
            }
        }
    }
}
