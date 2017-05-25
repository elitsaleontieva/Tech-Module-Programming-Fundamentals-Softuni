using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine() ;
            var currentHealth=int.Parse(Console.ReadLine());
            var maximumHealth= int.Parse(Console.ReadLine());
            var currentEnergy= int.Parse(Console.ReadLine());
            var maximumEnergy= int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
          
            Console.Write("Health: ");
            Console.Write("|");

            for (int i = 0; i < currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < Math.Abs(currentHealth-maximumHealth); i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

            Console.WriteLine();


            Console.Write("Energy: ");
            Console.Write("|");

            for (int i = 0; i < currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < Math.Abs(currentEnergy-maximumEnergy); i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

          

        }
    }
}
