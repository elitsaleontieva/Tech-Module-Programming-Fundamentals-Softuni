using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Continents_Countries_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SortedDictionary
                <string, SortedDictionary<string, SortedSet<string>>>();
            var n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var town = tokens[2];

                if (!data.ContainsKey(continent))
                
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();

                

                if (!data[continent].ContainsKey(country))
                
                    data[continent][country] =new SortedSet<string>();

                    data[continent][country].Add(town);

                

            }

            foreach (var continentAndCountries in data)
            {
                var continentName = continentAndCountries.Key;
                var townsByCountry = continentAndCountries.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var item in townsByCountry)
                {
                    var country = item.Key;
                    var towns = item.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ",towns)}");




                }


            }

            
        }

        }
    }
