/*
 * 
 * 
 * 
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;	
using System.Linq;
namespace Ununion
{
	class Program
	{
		public static void Main(string[] args)
		{
				//You will be given a sequence of integers, separated by a space. This is the primal list. 
		//Then you will receive an integer N. On the next N lines, you will receive sequences of integers. 
		//Your task is to add all elements that the primal list does not contain from the current sequence to the primal list
		//and then remove from the primal list, all elements which are contained in the current sequence of integers. If there are several occurrences,
		//remove all occurrences you find.
//After you are done receiving lists and manipulating the primal list, sort the primal list and print it.

		  var primal = Console.ReadLine().Split().Select(int.Parse).ToList();
 
            int count = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < count; i++)
            {
                var commands = Console.ReadLine().Split().Select(int.Parse).ToList();
 
                foreach (var command in commands)
                {
                    if (primal.Contains(command))
                    {
                        primal.Remove(command);
                    }
                    else
                    {
                        primal.Add(command);
                    }
                }
            }
 
            primal.Sort();
            Console.WriteLine(string.Join(" ", primal));
        }
    }
}