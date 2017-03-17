using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();
            var flattenedDictionary = new Dictionary<string, List<string>>();

            var tokens = Console.ReadLine().Split();

            while (tokens[0] != "end")
            {
                if (tokens.Length == 3)
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var value = tokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    dictionary[key][innerKey] = value;
                }

                else
                {
                    var flattenedKey = tokens[1];

                    foreach (var kvp in dictionary[flattenedKey])
                    {
                        var concatedKey = kvp.Key;
                        var concatedValue = kvp.Value;
                        var addedValue = concatedKey + concatedValue;

                        if (!flattenedDictionary.ContainsKey(flattenedKey))
                        {
                            flattenedDictionary[flattenedKey] = new List<string>();
                        }

                        flattenedDictionary[flattenedKey].Add(addedValue);
                    }

                    dictionary[flattenedKey] = new Dictionary<string, string>();
                }

                tokens = Console.ReadLine().Split();
            }

            foreach (var kvp in dictionary.OrderByDescending(x => x.Key.Length))
            {
                var count = 1;
                Console.WriteLine(kvp.Key);
                foreach (var innerValue in kvp.Value.OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{count}. {innerValue.Key} - {innerValue.Value}");
                    count++;
                }
                if (flattenedDictionary.ContainsKey(kvp.Key))
                {
                    foreach (var value in flattenedDictionary[kvp.Key])
                    {
                        Console.WriteLine($"{count}. {value}");
                        count++;
                    }
                }
            }
        }
    }
}
       