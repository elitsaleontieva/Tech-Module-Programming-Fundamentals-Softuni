using System;

namespace ExchangeVariableValues
{
    class Program
    {
        public static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine()); 
            
            int c = b; 
            b = a;
            a = c; 

            Console.WriteLine("{0}\n {1}\n", a, b);

        }
    }
}
