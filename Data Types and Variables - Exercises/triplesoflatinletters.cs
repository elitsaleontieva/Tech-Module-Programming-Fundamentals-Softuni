/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/27/2017
 * Time: 1:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dddddddddddd
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Write a program to read an integer n and print all triples of the first n small Latin letters, 
			//ordered alphabetically:
			
			
			int n= int.Parse(Console.ReadLine()); 
		
			for (char i='a'; i<n+'a'; i++){
				
				for (char j='a'; j<n+'a'; j++){
					
					for (char k='a'; k<n+'a'; k++){
						
						var letter1= (char) (i+'a');
						
							var letter2= (char) (j+'a');
						
							var letter3=(char) (k+'a');
						
						Console.WriteLine($"{i}{j}{k}");
					}
				}
			}
		}
	}
}

	