using System;



namespace ArrayElementsEqualtoTheirIndex

{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == i)
                {
                    Console.Write(array[i] + " "); //!!




                }

            }

        }
    }
}
