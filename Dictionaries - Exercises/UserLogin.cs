using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var users = new Dictionary<string, string>();

            var failedLoginAttempt = 0;

            while (line != "login")
            {
                var token = line.Split();
                var username = token[0];
                var password = token[token.Length - 1];

               users[username] = password;

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split();
                var userNameInput = token[0];
                var passwordInput = token[token.Length - 1];

                if (!users.ContainsKey(userNameInput) || !users.ContainsValue(passwordInput))
                {
                    Console.WriteLine("{0}: login failed", userNameInput);
                    failedLoginAttempt++;
                }
                else if (users.ContainsKey(userNameInput) || users.ContainsValue(passwordInput))
                {
                    Console.WriteLine("{0}: logged in successfully", userNameInput);
                }

                line = Console.ReadLine();

            }
            Console.WriteLine("unsuccessful login attempts: {0}", failedLoginAttempt);
        }
    }
}