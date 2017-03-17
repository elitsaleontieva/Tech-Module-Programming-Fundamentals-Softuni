using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            InsertSort(names);
            foreach (var item in names)
            {
                Console.Write("{0} ",item);
            }
        }

        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}