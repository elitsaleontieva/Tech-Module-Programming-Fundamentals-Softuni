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

	
namespace IntegerInsertion
{
	class Program
	{
		public static void Main(string[] args)
		{
			//You will receive a list of integers on the same line (separated by one space). On the next lines,
		//you will start receiving a list of strings, until you receive the string “end”. 
		//Your task is to insert each string (converted to integer) at a specific index in the list. The index is determined by the first digit of the number.
		  var integerInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
 
            var stringInput = Console.ReadLine();
 
            while ( stringInput != "end" )
            {
                int digit = (stringInput.ToString()[0]) - 48; //ascii value --> toString; cifrite v ascii zapochvat ot 48
 
                integerInput.Insert(digit, int.Parse(stringInput));
 
                stringInput = Console.ReadLine();
            }
 
            Console.WriteLine(string.Join(" ", integerInput));
        }
    }

}