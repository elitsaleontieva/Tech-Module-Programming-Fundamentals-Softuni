using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HappinessIndex
{
    class Program
    {
        static void Main(string[] args)
        {

                var emoticons = Console.ReadLine();

                Regex happy = new Regex(@":\)|:D|;\)|:\*|:]|;]|:]|:}|;}|\(:|\*:|c:|\[:|\[;");
                Regex sad = new Regex(@":\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];");


                var happyCount = happy.Matches(emoticons).Count;
                var sadCount = sad.Matches(emoticons).Count;
                var happinessIndex = happyCount / (double)sadCount;
                var choosing = choosingAnEmoticon(happinessIndex);

                Console.WriteLine($"Happiness index: {happinessIndex:F2} {choosing}");
                Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
            }

            private static string choosingAnEmoticon(double happinessIndex)
            {
                if (happinessIndex >= 2)
                {
                    return ":D";
                }
                else if (happinessIndex > 1)
                {
                    return ":)";
                }
                else if (happinessIndex == 1)
                {
                    return ":|";
                }
                else
                {
                    return ":(";
                }
                {

                }
            }
        }
    }
