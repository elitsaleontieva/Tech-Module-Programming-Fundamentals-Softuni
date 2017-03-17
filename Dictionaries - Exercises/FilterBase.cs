using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var NamesAndAges = new Dictionary<string, int>();
            var NamesAndPositions = new Dictionary<string, string>();
            var NamesAndSalaries = new Dictionary<string, decimal>();

            while (line != "filter base")
            {
                var input = line.Split();
                var name = input[0];
                var info = input[input.Length - 1];

                var ageCheck = 0;
                var salaryCheck = 0m;

                if (int.TryParse(info, out ageCheck))
                {
                    NamesAndAges[name] = ageCheck;
                }

                else if (decimal.TryParse(info, out salaryCheck))
                {
                    NamesAndSalaries[name] = salaryCheck;
                }

                else
                {
                    NamesAndPositions[name] = info;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            if (line == "Position")
            {
                foreach (var nameAndJob in NamesAndPositions)
                {
                    Console.WriteLine("Name: {0}", nameAndJob.Key);
                    Console.WriteLine("Position: {0}", nameAndJob.Value);
                    Console.WriteLine("====================");
                }
            }

            else if (line == "Age")
            {

                foreach (var nameAndAge in NamesAndAges)
                {
                    Console.WriteLine("Name: {0}", nameAndAge.Key);
                    Console.WriteLine("Age: {0}", nameAndAge.Value);
                    Console.WriteLine("====================");
                }
            }

            else
            {
                foreach (var nameAndSalary in NamesAndSalaries)
                {
                    Console.WriteLine("Name: {0}", nameAndSalary.Key);
                    Console.WriteLine("Salary: {0:f2}", nameAndSalary.Value);
                    Console.WriteLine("====================");
                }
            }
        
        }
    }
}
