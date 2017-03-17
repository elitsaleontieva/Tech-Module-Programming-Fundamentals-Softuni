using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
          

            var inputString = Console.ReadLine();
            var dictionary = new Dictionary<char,int>();

            foreach(var input in inputString)
            {
                if(!(dictionary.ContainsKey(input)))
                {
                    dictionary[input] = 0;
                }
                dictionary[input]++;
            }
            foreach (var result in dictionary) {
                Console.WriteLine(String.Join(" -> ", result.Key, result.Value));
            }
        }
    }
}
