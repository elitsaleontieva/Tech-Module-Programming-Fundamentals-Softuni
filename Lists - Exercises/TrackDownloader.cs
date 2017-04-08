using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

                var blackList = Console.ReadLine().Split();
                var input = Console.ReadLine();
                var newList = new List<string>();

           
            while (input != "end")
                {

                var inBlackList = false;

                for (int i = 0; i < blackList.Length; i++)
                    {
                        if (input.Contains(blackList[i]))
                        {
                            inBlackList = true;
                        }

                    }

                    if (inBlackList != true)
                    {
                        newList.Add(input);
                    }

                input = Console.ReadLine();
                }
               
                Console.WriteLine(String.Join($"{Environment.NewLine}", newList.OrderBy(x => x)));

            
            }
        }
    }
