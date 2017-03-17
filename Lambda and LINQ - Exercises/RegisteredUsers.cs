using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var usernameAndDate = new Dictionary<string, DateTime>();
         

            var command = Console.ReadLine();
            while (command != "end")
            {
               
               
                string [] tokens = command.Split(new [] { ' ', '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // usernameAndDate.Add(username, date);
                usernameAndDate[username] = date;

                command = Console.ReadLine();

            }
           
            Dictionary<string, DateTime> resultDictionary = usernameAndDate
                .Reverse()
                .OrderBy(x => x.Value).
                Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x=> x.Value);
            //reverse-if any entries have the SAME date, print the LAST entered one, FIRST, and then the other (in input).

            foreach (var result in resultDictionary)
            {
                
                Console.WriteLine("{0}", result.Key);
            }
            
            

            
        }
    }
}
