using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "end")
            {
                string pattern =@"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replace);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
