using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            
      
                    Rectangle rectangleInput1 = InputRectangle();
                    Rectangle rectangleInput2 = InputRectangle();
                    Console.WriteLine(rectangleInput1.isInside(rectangleInput2) ? "Inside" : "Not inside");
                }

                static Rectangle InputRectangle()
        {
                    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    Rectangle rectangle = new Rectangle();
                    rectangle.Left = input[0];
                    rectangle.Top = input[1];
                    rectangle.Width = input[2];
                    rectangle.Height = input[3];
                    return rectangle;
                }
            }
    class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int CalcArea()
            {
                return Width * Height;
            }
            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public bool isInside(Rectangle rectangle)
            {
                return (rectangle.Left <= Left) && (rectangle.Right >= Right) && (rectangle.Top <= Top) && (rectangle.Bottom >= Bottom);
            }
        }
    }
