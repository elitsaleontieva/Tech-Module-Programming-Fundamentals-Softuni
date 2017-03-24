using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPointsXY
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Point p1 = Point.GetPoint();
                Point p2 = Point.GetPoint();
                double distance = Point.CalcDistance(p1, p2);
                Console.WriteLine(distance);

            }
        }

        class Point
        {
            public double x { get; set; }
            public double y { get; set; }

            public static Point GetPoint()
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                Point point = new Point() { x = input[0], y = input[1] };
                return point;
            }

            public static double CalcDistance(Point p1, Point p2)
            {
                double resX = p1.x - p2.x;
                double resY = p1.y - p2.y;
                double distance = Math.Sqrt(Math.Pow(resX, 2) + Math.Pow(resY, 2));
                return distance;
            }
        }
    }
