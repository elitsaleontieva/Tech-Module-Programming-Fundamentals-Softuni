using System;



namespace TrickyStrings
{
    class Program
    {
        public static void Main(string[] args)
        {

            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result1 = string.Empty;
            string result2 = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                string toBeprinted = Console.ReadLine();

                if (i <= numberOfStrings - 1)
                {
                    result1 = result1 + toBeprinted + delimiter;
                }
                else
                {
                    result2 = toBeprinted;

                }

            }
            Console.WriteLine($"{result1}{result2}");
        }
    }
}
