using System;
using System.Linq;


namespace CharRotation

{
    class Program
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            string result = "";
            int[] numberInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < stringInput.Length; i++)
            {



                if (numberInput[i] % 2 == 0)
                {


                    result += (char)(stringInput[i] - numberInput[i]);

                }
                else
                {


                    result += (char)(stringInput[i] + numberInput[i]);

                }




            }
            Console.WriteLine(result);
        }

    }
}
