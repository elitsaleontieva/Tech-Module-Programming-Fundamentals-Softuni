using System;

namespace IncrementVariable
{
    class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            byte variable = 0; //max value=255
            int timesOverflow = 0; //overflow-kolko puti
            for (int i = 0; i < n; i++)
            {

                variable++;

                if (variable == 0)
                {
                    timesOverflow++;
                }
            }
            Console.WriteLine(variable);
            Console.WriteLine("Overflowed {0} times", timesOverflow);
        }
    }

}
