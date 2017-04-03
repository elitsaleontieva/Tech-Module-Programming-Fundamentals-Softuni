using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(' ', ',');
            var input = Console.ReadLine();

            foreach (var banned in bannedWords)
            {
                if (input.Contains(banned))
                {
                    if (banned.Length > 0)
                    {
                        input = input.Replace(banned, new String('*', banned.Length));
                    }
                    }
            }
            Console.WriteLine(input);
        }
    }
}
