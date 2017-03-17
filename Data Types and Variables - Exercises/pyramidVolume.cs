/*
 * Created by SharpDevelop.
 * User: Eli
 * Date: 1/29/2017
 * Time: 1:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dddddddddd
{
	class Program
	{
		public static void Main(string[] args)
		{
			double length, width, height = 0;
Console.Write("Length: ");
length = double.Parse(Console.ReadLine());
Console.Write("Width: ");
width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
height = double.Parse(Console.ReadLine());
double volume = (length * width * height) / 3;
Console.WriteLine("Pyramid Volume: {0:F2}", volume); 
		}
	}
}