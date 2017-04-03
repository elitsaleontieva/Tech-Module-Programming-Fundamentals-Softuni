using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Palindromes
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedSet<string>();

            foreach (var str in input)
            {
                if (IsPalindrome(str))
                {
                    result.Add(str);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }


        public static bool IsPalindrome(string value)
        {
            var reversed = value.ToCharArray().Reverse();

            reversed = string.Join("", reversed);

            if (value.Equals(reversed))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


