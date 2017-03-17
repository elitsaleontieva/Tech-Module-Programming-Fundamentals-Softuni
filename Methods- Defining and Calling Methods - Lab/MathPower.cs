using System;


namespace MathPower
{
    class Program
    {
        public static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double numPowerOfTwo = GetTriangleArea(number1, power);

            Console.WriteLine(numPowerOfTwo);
        }
        static double GetTriangleArea(double number1, int power)
        {

            return Math.Pow(number1, power);
        }
    }
}
