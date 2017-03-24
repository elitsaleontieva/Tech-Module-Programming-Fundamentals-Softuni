using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWordss
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordInput = Console.ReadLine().Split(' ').ToArray();
            var random = new Random();

            for (int i = 0; i < wordInput.Length; i++)
            {
                var element = wordInput[i];
                var randomElement = random.Next(0, wordInput.Length);

                //swap
                var temp = wordInput[randomElement];
                wordInput[randomElement] = element;
                wordInput[i] = temp;


            }



            foreach (var word in wordInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
