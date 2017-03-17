using System;



namespace SumArrayElements
{
    class Program
    {
        public static void Main(string[] args)
        {
            int lengthOfArray = int.Parse(Console.ReadLine());

            var numbers = new int[lengthOfArray];

            for (int i = 0; i < numbers.Length; i++)

                numbers[i] = int.Parse(Console.ReadLine());
            int sum = 0;




            for (int i = 0; i < numbers.Length; i++)

                sum += numbers[i];




            Console.WriteLine(sum);

        }
    }
}
