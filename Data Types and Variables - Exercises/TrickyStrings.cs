using System;


namespace TrickyStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string result2 = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                string toBeprinted = Console.ReadLine();

                if (i <= number - 1)
                {
                    result = result + toBeprinted + delimiter;
                }
                else
                {
                    result2 = toBeprinted;

                }

            }
            Console.WriteLine($"{result}{result2}");
        }
    }
}
