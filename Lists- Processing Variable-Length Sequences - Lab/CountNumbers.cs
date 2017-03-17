using System;
using System.Collections.Generic;
using System.Linq;


namespace CountNumbers

{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = new int[numbers.Max() + 1];

            foreach (var num in numbers)
            {
                count[num]++;

            }
            for (int i = 0; i < count.Length; i++)
            {
                numbers.Sort();
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, count[i]);
                }

            }

        }
    }


    }



    
