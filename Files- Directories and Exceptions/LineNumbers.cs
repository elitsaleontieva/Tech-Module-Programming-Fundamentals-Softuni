using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("Input.txt");

            var Lines = new List<string>();

            for (int i = 0; i < fileLines.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i+1}. {fileLines[i]}{Environment.NewLine}");
                
            }

        }
    }
}
