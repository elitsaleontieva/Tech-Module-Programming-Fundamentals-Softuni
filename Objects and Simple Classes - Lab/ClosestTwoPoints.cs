using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            Point[] points = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                points[i] = Pointinput(Console.ReadLine());
            }

            Point[] closestPoints = FindClosestPoints(points);
            foreach (Point point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }

        static Point Pointinput(string pointInput)
        {
            int[] coordinates = pointInput.Split(' ').Select(int.Parse).ToArray();
            return new Point() { X = coordinates[0], Y = coordinates[1] };
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double shortestDistance = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (CalcPointDistance(points[i], points[j]) < shortestDistance)
                    {
                        shortestDistance = CalcPointDistance(points[i], points[j]);
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            Console.WriteLine("{0:F3}", shortestDistance);
            return closestPoints;
        }

        static double CalcPointDistance(Point point1, Point point2)
        {
            int resX = point1.X - point2.X;
            int resY = point1.Y - point2.Y;

            return Math.Sqrt(resX * resX + resY * resY);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
      