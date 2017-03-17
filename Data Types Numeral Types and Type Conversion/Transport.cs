
using System;

namespace Transport
{
    class Program
    {
        public static void Main(string[] args)
        {

            var n = double.Parse(Console.ReadLine());
            double a = n;

            double courses = Math.Ceiling(n / (4 + 8 + 12));
            Console.WriteLine(courses);
        }
    }
}
