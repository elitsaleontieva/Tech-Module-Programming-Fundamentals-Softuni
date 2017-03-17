using System;
using System.Collections.Generic;
using System.Linq;


namespace TrackDownloader

{
    class Program
    {
        public static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split();
            var input = Console.ReadLine();
            var newList = new List<string>();
            while (input != "end")
            {
                bool inBlackList = false;
                for (int i = 0; i < blackList.Length; i++)
                {
                    if (input.Contains(blackList[i]))
                    {
                        inBlackList = true;
                    }
                }

                if (inBlackList != true)
                {
                    newList.Add(input);
                }
                input = Console.ReadLine();
            }

            foreach (var list in newList.OrderBy(x => x))
            {
                Console.WriteLine(list);
            }
        }
    }
}
