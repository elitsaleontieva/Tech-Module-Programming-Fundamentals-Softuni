using System;


namespace MultiplyEvensbyOdds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));


        }
        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;


        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    Math.Abs(sum += lastDigit);
                }
                n /= 10;

            }

            return sum;
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    Math.Abs(sum += lastDigit);
                }
                n /= 10;

            }

            return sum;

        }
    }
}
