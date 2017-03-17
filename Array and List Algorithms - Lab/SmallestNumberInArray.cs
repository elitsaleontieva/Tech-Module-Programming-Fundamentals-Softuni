using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNum = int.MaxValue;
            var num = 0;


            foreach (var arr in array)
            {



                if (arr < minNum)
                {

                    minNum = arr;

                }
            }
            Console.WriteLine(minNum);
        }
    }
}
