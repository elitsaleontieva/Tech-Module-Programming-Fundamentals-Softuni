/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/25/2017
 * Time: 6:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Transport
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			//Calculate how many courses will be needed to transport n persons
//by using 3 vehicles with capacity of 4, 8 and 12 respectively.
			var n = double.Parse(Console.ReadLine());
		double a=n;
		
double courses = Math.Ceiling(n/ (4 + 8 + 12));
Console.WriteLine(courses);
		}
	}
}