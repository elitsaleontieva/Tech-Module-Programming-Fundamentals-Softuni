using System;



namespace EqualElementsinArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] element = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool equalElements = true;




            for (int i = 0; i < element.Length - 1; i++)
            {

                if ((element[i]) != (element[i + 1]))
                {
                    equalElements = false;

                    Console.WriteLine("No");
                    return;
                }
                if (equalElements)
                {
                    Console.WriteLine("Yes");
                    return;
                }



            }



        }
    }


}
