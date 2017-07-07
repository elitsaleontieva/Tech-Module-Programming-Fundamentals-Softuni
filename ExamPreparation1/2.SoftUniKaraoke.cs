using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {

            var participantList = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            var songList = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<string>>();



            while (input != "Dawn" && input != "dawn")
            {
                var participantSongAward = input.Split(',').Select(x => x.Trim()).ToList(); 

                var participant = participantSongAward[0];
                var song = participantSongAward[1];
                var award = participantSongAward[2];


                if (participantList.Contains(participant) && songList.Contains(song))
                {

                    if (!dictionary.ContainsKey(participant))
                    {

                        dictionary[participant] = new List<string>();
                    }

                    if (!dictionary[participant].Contains(award))
                    {
                        dictionary[participant].Add(award);
                    }
                    

                }



                input = Console.ReadLine();
            }

            if (dictionary.Any())
            {


                foreach (var item in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(z => z.Key))
                {
                    if (item.Key.Any())
                    {

                        Console.WriteLine($"{item.Key}: {item.Value.Distinct().Count()} awards");
                        foreach (var item1 in item.Value.Distinct().OrderBy(x => x))
                        {
                            Console.WriteLine($"--{item1}");
                        }
                    }



                }

            }
            else
            {
                Console.WriteLine("No awards");
            }



        }



    }
}



