using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
           var grades = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var item = Console.ReadLine().Split();
                var name = item[0];  //left part
                var grade = double.Parse(item[1]);//right part

                if (!grades.ContainsKey(name))
                    grades[name] = new List<double>();

                grades[name].Add(grade);
            }

            foreach (var element in grades)
            {
                var name = element.Key;
                var gradeValue = element.Value;

                var average = gradeValue.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in gradeValue)
                    Console.Write($"{grade:f2} ");

                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
