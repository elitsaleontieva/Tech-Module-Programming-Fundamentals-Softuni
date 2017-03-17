using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var forumTopicsDictionary = new Dictionary<string, HashSet<string>>();

            while (input[0] != "filter")
            {
                var forumtTopic = input[0];
                var tags = input.GetRange(1, input.Count - 1);

                if (!forumTopicsDictionary.ContainsKey(forumtTopic))
                {
                    forumTopicsDictionary[forumtTopic] = new HashSet<string>();
                }

                foreach (var tag in tags)
                {
                    forumTopicsDictionary[forumtTopic].Add(tag);
                }

                input = Console.ReadLine().Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var commandFilter = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var topic in forumTopicsDictionary)
            {
                var allTagsIncluded = !commandFilter.Except(topic.Value).Any();

                if (allTagsIncluded)
                {
                    Console.WriteLine($"{topic.Key} | #{string.Join(", #", topic.Value)}");
                }
            }
        }
    }
}