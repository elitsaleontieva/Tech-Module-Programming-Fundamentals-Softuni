using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {

            var cardsInput = Console.ReadLine();

            Regex regex = new Regex("([1]?[0-9JKQA])([SHDC])");

            var matches = regex.Matches(cardsInput);

            var cards = new List<string>();

            foreach (Match match in matches)
            {
                var power = 0;

                if (int.TryParse(match.Groups[1].ToString(), out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                cards.Add(match.ToString());
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}