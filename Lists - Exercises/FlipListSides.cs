
using System;
using System.Collections.Generic;	
using System.Linq;
namespace FlipListSides
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
 
            List<int> firstPart = new List<int>();
            List<int> secondPart = new List<int>();
            List<int> result = new List<int>();
 
            int firstNum = input[0];
            int lastNum = input[input.Count - 1];
            int middleNum = input[input.Count / 2];
 
            for (int i = 0; i < input.Count / 2 - 1; i++)
            {
                firstPart.Add(input[i + 1]);
            }
 
            firstPart.Reverse();
            input.Reverse();
 
            for (int i = 0; i < input.Count / 2 - 1; i++)
            {
                secondPart.Add(input[i + 1]);
            }
 
            if (input.Count ==1)
            {
                Console.WriteLine(firstNum);
            }
            else if (input.Count == 2)
            {
                Console.WriteLine(firstNum + " " + lastNum);
            }
            else if (input.Count == 3)
            {
                Console.WriteLine($"{firstNum} {middleNum} {lastNum}");
            }
            else if (input.Count % 2 != 0)
            {
                Console.WriteLine(firstNum + " " + (string.Join(" ", secondPart)) + " " + middleNum + " " + (string.Join(" ", firstPart)) + " " + lastNum);
            }
            else
            {
                Console.WriteLine(firstNum + " " + (string.Join(" ", secondPart)) + " " + (string.Join(" ", firstPart)) + " " + lastNum);
            }
        }
    }
}
