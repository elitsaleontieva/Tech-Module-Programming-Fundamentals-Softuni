using System;



namespace IncreasingSequenceOfElements

{
    class Program
    {
        public static void Main(string[] args)
        {
            string length = Console.ReadLine();
            int[] element = length.Split().Select(int.Parse).ToArray();
            bool increasing = false;
            for (int i = 0; i < element.Length - 1; i++)
            {
                if (element[i] < element[i + 1])
                {
                    increasing = true;
                }
                else
                {
                    increasing = false;
                    Console.WriteLine("No");
                    break;

                }
            }
            if (increasing)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
