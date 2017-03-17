
using System;

namespace RefactorSpecialNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
int sum = 0; int result = 0; bool condition = false;
for (int i = 1; i <= number; i++)
{
result = i;
while (i > 0)
{
sum += i % 10;
i = i / 10;
}
condition = (sum == 5) || (sum == 7) || (sum == 11);
Console.WriteLine($"{result} -> {condition}");
sum = 0; i = result;
}
	}
}
}
