using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var convertInputToDateTime = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(convertInputToDateTime.DayOfWeek);
        }
    }
}
