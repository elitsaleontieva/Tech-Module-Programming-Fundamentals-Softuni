using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var banksAndAccounts = new Dictionary<string, Dictionary<string, decimal>>();
            var command = Console.ReadLine();
           

            while (!command.Equals("end"))
            {
                var tokens = command.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var bankName = tokens[0];
                var bankAccountName = tokens[1];
                var bankAccountBalance = decimal.Parse(tokens[2]);

                if (!banksAndAccounts.ContainsKey(bankName))
                {
                    banksAndAccounts[bankName] = new Dictionary<string, decimal>();
                }

                if (!banksAndAccounts[bankName].ContainsKey(bankAccountName))
                {
                    banksAndAccounts[bankName].Add(bankAccountName, 0);
                }

                banksAndAccounts[bankName][bankAccountName] += bankAccountBalance;
                command = Console.ReadLine();
            }

            banksAndAccounts.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value.OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})", account.Key, account.Value, bank.Key)));


        }
    }
}