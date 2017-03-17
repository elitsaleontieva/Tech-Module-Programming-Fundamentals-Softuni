using System;
using System.Collections.Generic;
using System.Linq;


namespace SquareNumbers

{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
           
            double square = 0;

            foreach (var num in numbers)
            {

                square = Math.Sqrt(num);


                if (square == (int)square)
                {
                    result.Add(num);
                }

            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(String.Join(" ", result));

        }
    }
}


    
