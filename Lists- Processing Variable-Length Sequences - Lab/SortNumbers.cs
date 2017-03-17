using System;
using System.Collections.Generic;
using System.Linq;


namespace SortNumbers

{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(String.Join("<=", numbers));
        }
    }
}
