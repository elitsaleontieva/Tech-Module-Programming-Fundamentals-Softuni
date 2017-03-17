
using System;
using System.Collections.Generic;	
using System.Linq;					

	
namespace IntegerInsertion
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		  var integerInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
 
            var stringInput = Console.ReadLine();
 
            while ( stringInput != "end" )
            {
                int digit = (stringInput.ToString()[0]) - 48; 
                integerInput.Insert(digit, int.Parse(stringInput));
 
                stringInput = Console.ReadLine();
            }
 
            Console.WriteLine(string.Join(" ", integerInput));
        }
    }

}
