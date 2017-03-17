using System;

namespace FromTerabytesToBits
{
    class Program
    {
        public static void Main(string[] args)
        {

            double teraBytes = double.Parse(Console.ReadLine());
            Console.WriteLine(teraBytes * 1024 * 1024 * 1024 * 1024 * 8);
        }
    }

}
