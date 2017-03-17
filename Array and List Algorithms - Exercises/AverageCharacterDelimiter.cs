using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split(' ').ToList();
            double charSum = 0;
            int charNum = 0;

            for (int i = 0; i < inputLine.Count; i++) 
            {
                charNum += inputLine[i].Count();
                double elementsSum = 0;
                foreach (var element in inputLine[i])
                {
                    elementsSum += (double)element; //get num value
                }
                charSum += elementsSum;
            }
            double sumAverage= charSum / charNum;
            if (sumAverage >= 97 && sumAverage <= 122)
            {
                sumAverage -= 32;
            }

            char delimeter = (char)(sumAverage);
            Console.WriteLine(string.Join(delimeter.ToString(), inputLine));
        }
    }
}


