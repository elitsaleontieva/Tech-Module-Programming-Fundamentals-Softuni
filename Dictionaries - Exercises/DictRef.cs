using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var resultDict = new Dictionary<string, int>();
            var line = Console.ReadLine();

            while (line != "end")
            {
               
                var split = line.Split();

                var firstElement = split[0];
                var lastElement = split[split.Length - 1];

                var number = 0;
                
                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else if (resultDict.ContainsKey(lastElement))
                {
                    var referencedVar = resultDict[lastElement];
                    resultDict[firstElement] = referencedVar;
                }




                line = Console.ReadLine();
            }
                    foreach (var dict in resultDict)
                    {
                        var key = dict.Key;
                        var value = dict.Value;
                        Console.WriteLine($"{key} === {value}");
                    }
                  
                }
            }

        }
    
