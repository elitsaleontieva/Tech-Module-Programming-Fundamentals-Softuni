using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            
            HashSet<string> setValues = new HashSet<string>();

            for(int i=0; i<num; i++)
            {
                var list = Console.ReadLine();
                setValues.Add(list);
               
            }
            foreach (var set in setValues)
            {
                Console.WriteLine(set);
            }

           
        }
    }
}
      //SortedSet