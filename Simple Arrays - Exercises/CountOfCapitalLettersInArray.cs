using System;



namespace CountOfCapitalLettersInArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split(' ');

            var count = 0;


            for (int i = 0; i < element.Length; i++)
            {
                string currentWord = element[i];
                if (currentWord.Length == 1)
                {


                    char character = currentWord[0];
                    if (character >= 65 || character <= 90)
                    {
                        count++;

                    }
                }



            }
            Console.WriteLine(count);

        }
    }

}
