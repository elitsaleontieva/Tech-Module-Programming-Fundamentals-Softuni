using System;



namespace CountGivenElementinArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            var elementLength = Console.ReadLine().Split();
            
            var element = new int[elementLength.Length];
            var repeatedElement = int.Parse(Console.ReadLine());

            var count = 0;

          

            for (int i = 0; i < element.Length; i++)
            {
                element[i] = int.Parse(elementLength[i]);
                if ((element[i]) == (repeatedElement))
                {

                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
}
