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
namespace DistinctList
{
	class Program
	{
		public static void Main(string[] args)
		{
			//You will be given a list of integers on the first line of the input (space-separated). Remove all repeating elements from the list.
		var list1=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
		
		Console.WriteLine(String.Join(" ",list1.Distinct()));
}
}
}