using System;



namespace CountofNegativeElementsinArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            var array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;


                }

                else
                {
                    //Console.WriteLine("0");

                }
            }
            Console.WriteLine(count);
        }
    }
}
