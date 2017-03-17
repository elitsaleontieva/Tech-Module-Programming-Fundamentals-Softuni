using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var numbers = new List<int>();
            var lastElement = 0;

            while (!inputLine.Equals("stop"))
            {
                if (!inputLine.Equals("bang"))
                {
                    var insertElement = Int32.Parse(inputLine);
                    numbers.Insert(0, insertElement);
                }

                if (inputLine.Equals("bang"))
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                        return;
                    }

                    var averageSum = numbers.Average();
                    var deleteElement = 0;

                    foreach (var num in numbers)
                    {
                        if (num <= averageSum)
                        {
                            deleteElement = num;
                            break;
                        }
                    }

                    numbers.Remove(deleteElement);
                    Console.WriteLine($"shot {deleteElement}");

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }

                    lastElement = deleteElement;

                }

                inputLine = Console.ReadLine();
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine($"survivors: {(string.Join(" ", numbers))}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
        }
    }
}