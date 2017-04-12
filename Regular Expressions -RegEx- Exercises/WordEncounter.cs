﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var letter = filter[0];
            var neededCount = int.Parse(filter[1].ToString());
            var filteredWords = new List<string>();

            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                string patternValidSentence = @"^[A-Z].*[.!?]$";
                var validSentence = new Regex(patternValidSentence);

                if (validSentence.IsMatch(sentence))
                {
                    var regex = new Regex(@"\w+");

                    var words = regex.Matches(sentence);

                    foreach (Match item in words)
                    {
                        var word = item.Groups[0].Value;

                        var count = 0;
                        foreach (var character in word)
                        {
                            if (character == letter)
                            {
                                count++;
                            }
                        }

                        if (count >= neededCount)
                        {
                            filteredWords.Add(word);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", filteredWords));
        }
    }
}