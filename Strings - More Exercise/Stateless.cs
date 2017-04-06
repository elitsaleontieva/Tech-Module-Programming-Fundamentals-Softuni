using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            while (command != "collapse")
            {
                var input = command;
                var exceptions = Console.ReadLine();

                while (exceptions.Length > 0)
                {
                    input = input.Replace(exceptions, "").Trim();

                    exceptions = exceptions.Remove(0, 1); //removes the first letter


                    if (exceptions.Length > 0)
                    {
                        exceptions = exceptions.Remove(exceptions.Length - 1, 1); //removes the last letter
                    }

                }

                if (input.Equals(String.Empty))
                {
                    Console.WriteLine("(void)");
                }

                Console.WriteLine(input);
 
                command = Console.ReadLine();
            }

        }
    }
}

   

