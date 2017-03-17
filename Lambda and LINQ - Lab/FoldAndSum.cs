﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {




            var numbers = Console.ReadLine().Split().Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var firstPartUpperRow = numbers.Take(k).Reverse().ToList();
            var secondPartUpperRow = numbers.Reverse().Take(k);

            var upperRow = firstPartUpperRow.Concat(secondPartUpperRow).ToArray();
            var lowerRow = numbers.Skip(k).Take(2 * k).ToArray();

            var result = new int[upperRow.Length];

            for(int i=0; i<upperRow.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(String.Join(" ",result));

        }
    }
}
