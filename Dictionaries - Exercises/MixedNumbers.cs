using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new SortedDictionary<string, decimal>();

            var line = Console.ReadLine();

            while (line!="Over")
            {
                var splittedLine = line.Split(" :".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                var firstElement = splittedLine[0];
                var secondElement = splittedLine[1];

                var phoneNumber = 0m;
                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    phoneNumbers[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    phoneNumbers[firstElement] = phoneNumber;
                }
                line = Console.ReadLine();
            }

            foreach (var result in phoneNumbers)
            {
                var name = result.Key;
                var phoneNumber = result.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
//input:
//14284124 : Alex
//Gosho : 088423123
//Ivan : 412048192
//123123123 : Nanyo
//Pesho : 150925812
//Over
//    output:
//    Alex -> 14284124
//Gosho -> 88423123
//Ivan -> 412048192
//Nanyo -> 123123123
//Pesho -> 150925812
