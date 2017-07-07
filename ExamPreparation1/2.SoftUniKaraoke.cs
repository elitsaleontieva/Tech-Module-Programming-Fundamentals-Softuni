using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {


            var timeToLeave = Console.ReadLine(); // HH: mm: ss
            var chars = ":".ToCharArray();
            var arr = timeToLeave.Split(chars, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var numOfStepsToHome = int.Parse(Console.ReadLine()) % 86400;
            var timeForStep = int.Parse(Console.ReadLine()) % 86400;

            var totalTime = (numOfStepsToHome * timeForStep) % 86400;
            var hours = (int.Parse(arr[0]) * 3600) % 86400;
            var minutes = (int.Parse(arr[1]) * 60 )%86400;
            var seconds = int.Parse(arr[2]) % 86400;
            var secondsTotal =( hours + minutes + seconds + totalTime) % 86400;
            TimeSpan t = TimeSpan.FromSeconds(secondsTotal);
           
            
            var hours1 = (int)t.TotalHours;
            var minutes1 = t.Minutes;
            var seconds1 = t.Seconds;
           
                Console.Write("Time Arrival: ");
                Console.WriteLine("{0:D2}:{1:D2}:{2:D2}",
                  ((int)t.TotalHours),
                  (t.Minutes),
                  (t.Seconds));
          
            }




        }


    



}
