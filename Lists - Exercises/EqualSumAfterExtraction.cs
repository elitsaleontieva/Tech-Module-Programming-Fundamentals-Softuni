using System;
using System.Collections.Generic;
using System.Linq;


namespace EqualSumAfterExtraction

{
    class Program
    {
        public static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < list1.Count; i++)
            {

                for (int j = 0; j < list2.Count; j++)
                {

                    if (list1[i] == list2[j])
                    {
                        list2.RemoveAll(item => item == list1[i]);
                    }
                }
            }







            if ((list1.Sum()) == (list2.Sum()))
            {

                Console.WriteLine("Yes. Sum: {0}", list1.Sum());


            }

            else
            {

                Console.WriteLine("No. Diff: {0}", (Math.Abs((list1.Sum()) - (list2.Sum()))));

            }


        }
    }

}
