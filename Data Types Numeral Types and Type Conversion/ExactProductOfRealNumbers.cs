/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/25/2017
 * Time: 6:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExactProductOfRealNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Write program to enter n numbers and calculate and print their exact product (without rounding).
			int n = int.Parse(Console.ReadLine());
			double product = 0;
			for (int i = 0; i < n; i++)
			product *= double.Parse(Console.ReadLine());
			Console.WriteLine(product);
		}
	}
}