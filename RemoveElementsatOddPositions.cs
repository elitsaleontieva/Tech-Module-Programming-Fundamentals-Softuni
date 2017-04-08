using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsatOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            var newList = new List<string>();

            for (int i = 1; i < list.Count; i++)
            {
                
                if (i % 2 != 0)
                {
                    newList.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join("",newList));
        }
    }
}
