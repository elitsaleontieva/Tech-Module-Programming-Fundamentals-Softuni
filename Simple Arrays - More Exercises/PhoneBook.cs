using System;



namespace PhoneBook

{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');

            string[] names = Console.ReadLine().Split(' ');

            string input = Console.ReadLine();

            while (input != ("done"))
            {



                PrintElement(names, phoneNumbers, input);
                input = Console.ReadLine();

            }
        }

        public static void PrintElement(string[] names, string[] phoneNumbers, string input)
        {

            for (int i = 0; i < names.Length; i++)
            {

                if (names[i].Equals(input))
                {
                    Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                }


            }



        }

    }


}
