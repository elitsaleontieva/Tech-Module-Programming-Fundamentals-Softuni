using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {

            var continentCountryTown = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var continent = tokens[0];
                var country = tokens[1];
                var town = tokens[2];
                if (!continentCountryTown.ContainsKey(continent))
                    continentCountryTown[continent] =
                      new Dictionary<string, List<string>>();

                if (!continentCountryTown[continent].ContainsKey(country))
                    continentCountryTown[continent][country] = new List<string>();

                continentCountryTown[continent][country].Add(town);
            }
            foreach (var countriesInContinent in continentCountryTown)
            {
                var nameOfContinent = countriesInContinent.Key;
                var countriesOfContient = countriesInContinent.Value;

                Console.WriteLine($"{nameOfContinent}:");
                foreach (var countryCities in countriesOfContient)
                {
                    var nameOfCountry = countryCities.Key;
                    var cityOfCountry = countryCities.Value;
                    Console.WriteLine("  {0} -> {1}",
                      nameOfCountry, string.Join(", ", cityOfCountry));
                }
            }
        }

    }
}

//iput
//            9
//Europe Bulgaria Sofia
//Asia China Beijing
//Asia Japan Tokyo
//Europe Poland Warsaw
//Europe Germany Berlin
//Europe Poland Poznan
//Europe Bulgaria Plovdiv
//Africa Nigeria Abuja
//Asia China Shanghai



//output
//            //Europe:
//            Bulgaria->Sofia, Plovdiv
//  Poland->Warsaw, Poznan
//  Germany->Berlin
//Asia:
//            China->Beijing, Shanghai
//  Japan->Tokyo
//Africa:
//            Nigeria->Abuja
