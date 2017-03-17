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
namespace EqualSumAfterExtraction
{
	class Program
	{
		public static void Main(string[] args)
		{
		//You will be given two integer lists on the first two lines (space-separated). 
		////Remove the elements in the first list from the elements in the second list. If an element from the first 
			//list occurs more than once in the second list, remove all occurrences.
//After you remove the elements, check the sum of both lists. 
		//If the sum of both of them is equal, print “Yes. Sum: {sum}”. If not print the absolute difference between the two lists in the format “No. Diff: {sum}”.
		var list1=Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
		var list2=Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 
		
		
		for(int i=0; i<list1.Count ; i++){
				
			for(int j=0; j<list2.Count; j++){
				
				if(list1[i]==list2[j]){
			list2.RemoveAll(item => item ==list1[i]);
				}
			}
		}
				
				
			
				
			
		
			 
			if((list1.Sum())==(list2.Sum())){ 
				
				Console.WriteLine("Yes. Sum: {0}",list1.Sum());
			
				
			}
			
			else{ 
				
				Console.WriteLine("No. Diff: {0}",(Math.Abs((list1.Sum())-(list2.Sum()))));
				
			}
			
			
		}
	}

}
