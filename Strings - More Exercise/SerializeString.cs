using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitInput = input.ToCharArray().ToList();
            var distinct = splitInput.Distinct().ToList();
            var list = new List<string>();

            for(int i=0; i<distinct.Count; i++)
            {
               
                for (int j = 0; j < splitInput.Count; j++)
                {
                    if (distinct[i].Equals(splitInput[j]))
                    {
                        list.Add(j.ToString());
                        
                    }
                }
                Console.Write(($"{distinct[i]}:"));
                Console.WriteLine($"{String.Join("/", list)}");
                list.Clear();
            }

           
        }
    }
}