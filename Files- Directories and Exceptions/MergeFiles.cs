using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllText("FileOne.txt").Split();
            string[] secondFile = File.ReadAllText("FileTwo.txt").Split('\r', '\n');
            File.WriteAllText("result.txt", "");

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + "\r\n" + secondFile[i]);
            }





        }

    }
}