using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fileLines = File.ReadAllLines("Input.txt");

            var oddLines = new List<string>();

            for (int i = 1; i < fileLines.Length; i+=2)
            {
                oddLines.Add(fileLines[i]);
            }

            File.WriteAllLines("output.txt",oddLines);
        }
    }
}
