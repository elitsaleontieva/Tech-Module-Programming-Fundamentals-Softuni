
using System;

namespace TripplesOfLatinletters
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < n + 'a'; i++)
            {

                for (char j = 'a'; j < n + 'a'; j++)
                {

                    for (char k = 'a'; k < n + 'a'; k++)
                    {

                        var letter1 = (char)(i + 'a');

                        var letter2 = (char)(j + 'a');

                        var letter3 = (char)(k + 'a');

                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
