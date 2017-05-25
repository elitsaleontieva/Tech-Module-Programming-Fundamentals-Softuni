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
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            double volumePerMl = energyContent / 100.0;
            double sugarPerMl = (double)sugarContent / 100.0;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(energyContent*volume)/100.0}kcal, {(sugarContent*volume)/100.0}g sugars");
        }
    }
}
