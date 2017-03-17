using System;


namespace StringRepeater
{
    class Program
    {
        public static void Main(string[] args)
        {
            ar str = (Console.ReadLine());
            var count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }
    }
}
