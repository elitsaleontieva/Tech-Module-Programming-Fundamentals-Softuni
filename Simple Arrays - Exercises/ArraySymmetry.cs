using System;



namespace ArraySymmetry

{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            bool isSymetric = true;

            for (int i = 0; i < words.Length / 2; i++)
            {

                string firstWord = words[i]; //i=0 
                string secondWord = words[words.Length - 1 - i];


                if (firstWord != secondWord)
                {

                    isSymetric = false;
                    Console.WriteLine("No");
                    break;

                }

            }
            if (isSymetric)
            {

                Console.WriteLine("Yes");


            }


        }
    }
}
