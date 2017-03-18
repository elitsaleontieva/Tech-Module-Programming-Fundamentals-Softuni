using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var lambadaExpression = new Dictionary<string, Dictionary<string, List<string>>>();
            var command = Console.ReadLine();

            while (!command.Equals("lambada"))
            {
                if (!command.Equals("dance"))
                {
                    var tokens = command.Split(new[] { '=', '>', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var selector = tokens[0];
                    var selectorObjects = tokens[1];
                    var property = tokens[2];

                    if (!lambadaExpression.ContainsKey(selector))
                    {
                        lambadaExpression[selector] = new Dictionary<string, List<string>>();
                    }
                    if (!lambadaExpression[selector].ContainsKey(selectorObjects))
                    {
                        lambadaExpression[selector][selectorObjects] = new List<string>();
                    }
                    lambadaExpression[selector][selectorObjects].Clear();
                    lambadaExpression[selector][selectorObjects].Add(property);
                }
                else
                {
                    foreach (var lambdaExpressionKeyElement in lambadaExpression.Keys)
                    {
                        foreach (var element in lambadaExpression[lambdaExpressionKeyElement].Keys)
                        {
                            lambadaExpression[lambdaExpressionKeyElement][element].Insert(0, element);
                        }
                    }

                }
                command = Console.ReadLine();
            }
            foreach (var selectorVar in lambadaExpression.Keys)
            {
                Console.Write("{0} => ", selectorVar);
                foreach (var selectorObject in lambadaExpression[selectorVar].Keys)
                {
                    Console.WriteLine("{0}.{1}", selectorObject, string.Join(".", lambadaExpression[selectorVar][selectorObject]));
                }
            }
        }
    }
}

