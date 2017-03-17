using System;
using System.Collections.Generic;
using System.Linq;


namespace SumAdjacentEqualNumbers

{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {

                    numbers[i] += numbers[i - 1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;

                }

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
