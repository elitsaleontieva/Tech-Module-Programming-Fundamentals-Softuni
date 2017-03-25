using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> websitesList = new List<Website>();

            var info = Console.ReadLine();

            while (info != "end")
            {

                string[] inputParams = info.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);


                Website website = new Website();
                website.Domain = inputParams[1];
                website.Host = inputParams[0]; 
                website.Queries = new List<string>(); 


                websitesList.Add(website);

                for (int i = 2; i < inputParams.Length; i++)
                {
                    website.Queries.Add("[" + inputParams[i] + "]");
                }

                info = Console.ReadLine();
            }

            foreach (var website in websitesList)
            {
                if (website.Queries.Count > 1)
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");
                    Console.Write(string.Join("&", website.Queries));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
        class Website
        {

            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }
        }
    }
}