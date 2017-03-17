using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParameters = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string currentKey = inputParameters[0];
                int firstValue = -1; 

                if (int.TryParse(inputParameters[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey)) 
                    {
                        dictionary[currentKey] = new List<int>(); 
                    }

                    for (int i = 1; i < inputParameters.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParameters[i]));
                    }
                }
                else
                {
                    string otherKey = inputParameters[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} === " + string.Join(", ", entry.Value));
            }
        }
    }
}
      