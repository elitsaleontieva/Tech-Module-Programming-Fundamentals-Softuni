using System;
using System.Collections.Generic;
using System.Linq;


namespace RemoveNegativesAndReverse

{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            List<int> numbersResult = new List<int>();
            foreach (var num in numbers)
            {
                if (num > 0)
                {
                    numbersResult.Add(num);
                }
            }
            if (numbersResult.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbersResult));
            }

        }
    }
}
