

namespace Shellbound1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, HashSet<int>>();
            while (input != "Aggregate")
            {
                var tokens = input.Split();
                var town = tokens[0];
                var shell = int.Parse(tokens[1]);
                if (!dictionary.ContainsKey(town))
                {
                    dictionary[town] = new HashSet<int>();
                }
                dictionary[town].Add(shell);
                input = Console.ReadLine();
            }
            foreach (var dict in dictionary)
            {
                Console.WriteLine("{0} -> {1} ({2})", dict.Key,string.Join(", ", dict.Value), Math.Ceiling(dict.Value.Sum() - dict.Value.Average()));
            }
        }
    }
}
