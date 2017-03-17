
using System;

namespace PyramidVolume
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
C		onsole.WriteLine("Pyramid Volume: {0:F2}", volume); 
		}
	}
}
