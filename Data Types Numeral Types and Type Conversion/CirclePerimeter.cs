/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/25/2017
 * Time: 6:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CirclePerimeter
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Write program to enter a radius r (real number) and print the
//perimeter of a circle with 12 digits after the decimal point:
double r = double.Parse(Console.ReadLine());
Console.WriteLine("{0:f12}", 2 * Math.PI * r); //{0:f12} 12 digits after the decimal point
		}
	}
}