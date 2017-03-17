using System;



namespace CountOccurrencesofLargerNumbersinArray

{
    class Program
    {
        public static void Main(string[] args)
        {
            var elementLength = Console.ReadLine().Split();
            
            var element = new double[elementLength.Length];
            var p = double.Parse(Console.ReadLine());

            var count = 0;


            for (int i = 0; i < element.Length; i++)
            {
                element[i] = double.Parse(elementLength[i]);
                if ((element[i]) > (p))
                {

                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
    }
