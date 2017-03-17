
using System;

namespace Greeting
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string ageSTRING = Console.ReadLine();

            int age = int.Parse(ageSTRING);
            Console.WriteLine("Hello, {0} {1}.\r\nYou are {2} years old.", firstname, lastname, age);
        }
    }
}
