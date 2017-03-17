using System;



namespace RotateArrayofStrings

{
    class Program
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var result = new string[words.Length];
            result[0] = words[words.Length - 1];



            for (int i = 0; i < words.Length - 1; i++)
                result[i + 1] = words[i];

            var resultAsString = string.Join(" ", result);
            Console.WriteLine(resultAsString);
        }
    }
}
