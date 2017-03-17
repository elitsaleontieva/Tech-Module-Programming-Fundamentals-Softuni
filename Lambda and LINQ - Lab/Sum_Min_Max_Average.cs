using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var numbers = new double [length];
           

            for(int i=0; i<length; i++)
            {
                numbers [i] = double.Parse(Console.ReadLine());
                
            }
            
                Console.WriteLine("Sum = {0}",    String.Join("",numbers.Sum()));
                Console.WriteLine( "Min = {0}",   String.Join("",numbers.Min()));
                Console.WriteLine( "Max = {0}",   String.Join("",numbers.Max()));
                Console.WriteLine("Average = {0}",String.Join(" ", numbers.Average()));
            
        
         

           

        }
    }
}
