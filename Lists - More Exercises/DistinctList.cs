
using System;
using System.Collections.Generic;	
using System.Linq;	
namespace DistinctList
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		var list1=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
		
		Console.WriteLine(String.Join(" ",list1.Distinct()));
}
}
}
