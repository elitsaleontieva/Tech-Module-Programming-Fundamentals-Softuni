using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesInDirectory = Directory.GetFiles("TestFolder");
            double sizeOfFilesTotal = 0;

            foreach (string file in filesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                sizeOfFilesTotal += fileInfo.Length;
            }

            sizeOfFilesTotal = sizeOfFilesTotal / 1024 / 1024;

            File.WriteAllText("оutput.txt", sizeOfFilesTotal.ToString());

        }
    }
}
