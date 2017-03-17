using System;



namespace LargestElementinArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            int stringArray = int.Parse(Console.ReadLine());

            var array = new int[stringArray];

            for (int i = 0; i < array.Length; i++)

                array[i] = int.Parse(Console.ReadLine());



            int smallestNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)

                if (array[i] > smallestNumber)
                {   
                    smallestNumber = array[i];

                }
            Console.WriteLine(smallestNumber); 
        }
    }
}
