using System;

namespace DistanceOfStars
{
    class Program
    {
        public static void Main(string[] args)
        {

            decimal earthToItsNearestStar = 4.22M * 9450000000000;
            decimal distanceMilkyWay = 26000 * 9450000000000;
            decimal diameterMilkyWay = 100000 * 9450000000000;
            decimal distanceFromEarthToTheEdgeOfTheObservableUniverse = 46500000000M * 9450000000000;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", 
                earthToItsNearestStar.ToString("e2"), 
                distanceMilkyWay.ToString("e2"), 
                diameterMilkyWay.ToString("e2"), distanceFromEarthToTheEdgeOfTheObservableUniverse.ToString("e2"));

        }
    }
}
