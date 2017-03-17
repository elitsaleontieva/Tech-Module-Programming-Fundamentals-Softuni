
using System;
using System.Collections.Generic;	
using System.Linq;
namespace Ununion
{
	class Program
	{
		public static void Main(string[] args)
		{
				

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
