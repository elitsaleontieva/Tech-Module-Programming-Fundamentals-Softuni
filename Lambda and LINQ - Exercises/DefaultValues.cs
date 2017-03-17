using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyValuePairInput = new Dictionary<string, string>();
            var command = Console.ReadLine();
            while (command != "end")
            {

                string[] tokens = command.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = tokens[0];
                var value = (tokens[1]);


                keyValuePairInput[key] = value;

                command = Console.ReadLine();
            }
            var defaultValue = Console.ReadLine();

            //Then you must change all values, which are equal to “null” with the given default value.


            Dictionary<string, string> unchangedValues = keyValuePairInput
                .Where(x => x.Value != ("null"))
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);


            Dictionary<string, string> changedValues = keyValuePairInput
                .Where(z => z.Value.Equals("null"))
               .ToDictionary(z => z.Key, z => defaultValue);


      
                
            foreach (var unchanged in unchangedValues)
            {
                Console.WriteLine($"{unchanged.Key} <-> {unchanged.Value}");
            }

        
            foreach (var changed in changedValues)
            {
                Console.WriteLine($"{changed.Key} <-> {changed.Value}");
            }







        }
    }
}
