using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            List<string> words = new List<string>();

            List<int> num = new List<int>();

            for (int i=0; i < array.Length; i++)
            {
                if (!words.Contains(array[i]))
                {
                    words.Add(array[i]);
                    num.Add(1);
                }
                else
                {
                    for (int j=0; j < words.Count; j++)
                    {
                        if (array[i] == words[j])
                        {
                            num[j]++;
                        }
                    }
                }
            }
            bool notSorted = true;
            while (notSorted)
            {
                notSorted = false;
                for (int i = 0; i < num.Count - 1; i++)
                {
                    if (num[i] < num[i+1])
                    {
                        int temp = num[i];
                        num[i] = num[i+1];
                        num[i+1] = temp;

                        string tempStringVar = words[i];
                        words[i] = words[i+1];
                        words[i+1] = tempStringVar;

                        notSorted= true;
                    }

                }
            }


            for (int i=0; i < words.Count; i++)
            {
                double resultInPercent = (num[i]*100.0)/array.Length;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], num[i], resultInPercent);
            }
        }
    }
}
 