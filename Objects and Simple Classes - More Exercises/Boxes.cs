using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    
            public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            
            public static double Distance(Point point1, Point point2)
            {
                var X = Math.Abs(point1.X - point2.X);
                var Y = Math.Abs(point1.Y - point2.Y);

                return Math.Sqrt(Math.Pow((X), 2) + Math.Pow((Y), 2));
            }
        }

        public class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }

            public static int Perimeter(int widht, int height)
            {
                return ((2 * widht) + (2 * height));
            }
            public static int Area(int width, int height)
            {
                return (width * height);
            }
        }

namespace _
    {
        class Program
        {
            static void Main(string[] args)
            {
                var boxList = new List<Box>();
                var input = Console.ReadLine();

                while (input != "end")
                {
                    var tokens = input.Split(new[] { ' ', ':', '|' },StringSplitOptions.RemoveEmptyEntries);

                    var box = new Box();

                    box.UpperLeft = inputPoint(int.Parse(tokens[0]), int.Parse(tokens[1]));
                    box.UpperRight = inputPoint(int.Parse(tokens[2]), int.Parse(tokens[3]));
                    box.BottomLeft = inputPoint(int.Parse(tokens[4]), int.Parse(tokens[5]));
                    box.BottomRight = inputPoint(int.Parse(tokens[6]), int.Parse(tokens[7]));
                    boxList.Add(box);

                    input = Console.ReadLine();
                }

                foreach (var box in boxList)
                {
                    var width = Point.Distance(box.UpperLeft, box.UpperRight);
                    var height = Point.Distance(box.UpperLeft, box.BottomLeft);

                    Console.WriteLine($"Box: {width}, {height}");
                    Console.WriteLine($"Perimeter: {Box.Perimeter((int)width, (int)height)}");
                    Console.WriteLine($"Area: {Box.Area((int)width, (int)height)}");
                }
            }

            private static Point inputPoint(int p1, int p2)
            {
                var point = new Point
                {
                    X = p1,
                    Y = p2
                };
                return point;
            }
        }
    }
}
    
