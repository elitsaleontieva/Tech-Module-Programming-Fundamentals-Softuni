using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            var indexOf = input.IndexOf(pattern);

            var count = 0;
            
            for(int i=0; i<input.Length; i++)
            {
                if (indexOf != -1) 
                {
                    indexOf = (input.IndexOf(pattern, indexOf + 1));

                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
