using System;



namespace MultiplyanArrayofDoubles
{
    class Program
    {
        public static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split();
            
            var multiplication = new double[stringArray.Length];



            for (int i = 0; i < multiplication.Length; i++)


                multiplication[i] = double.Parse(stringArray[i]); //string to double
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < multiplication.Length; i++)
                multiplication[i] *= p;



            for (int i = 0; i < multiplication.Length; i++)

                Console.Write(multiplication[i] + " ");

        }
    }
}
