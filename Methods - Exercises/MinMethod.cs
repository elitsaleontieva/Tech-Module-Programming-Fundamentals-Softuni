using System;


namespace MinMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            GetMin(a, b);
        }

        static void GetMin(int a, int b)
        {
            var c = int.Parse(Console.ReadLine());
            if (a < b && a < b)
            {
                Console.WriteLine(a);
            }
            if (b < a && b < c)
            {
                Console.WriteLine(b);
            }

            if (c < b && c < a)
            {
                Console.WriteLine(c);
            }
        }
    }
}
  
