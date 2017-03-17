using System;



namespace OddNumbersatOddPositions

{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(numbers[i] % 2) == 1)
                {
                    Console.WriteLine("Index {0} -> {1}", i, numbers[i]);


                }
            }
        }
    }
}
