using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendLists

{
    class Program
    {
        public static void Main(string[] args)
        {
            var stringInput = Console.ReadLine().Split('|').ToList();
            stringInput.Reverse();
            Console.WriteLine(string.Join(" ", stringInput));
        }
    }
}


