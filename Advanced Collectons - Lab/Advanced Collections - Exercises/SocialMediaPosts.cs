using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var socialMediaDictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            var input = Console.ReadLine();

            while (input != "drop the media")
            {
                var tokens = input.Split(' ').ToArray();
                var command = tokens[0];
                var post = tokens[1];

                if (!socialMediaDictionary.ContainsKey(post))
                {
                    socialMediaDictionary[post] = new Dictionary<string, List<string>>();
                }
                if (command == "like")
                {
                    if (!socialMediaDictionary[post].ContainsKey("Like"))
                    {
                        socialMediaDictionary[post]["Like"] = new List<string>();
                    }

                    socialMediaDictionary[post]["Like"].Add(command);
                }
                else if (command == "dislike")
                {
                    if (!socialMediaDictionary[post].ContainsKey("Dislike"))
                    {
                        socialMediaDictionary[post]["Dislike"] = new List<string>();
                    }

                    socialMediaDictionary[post]["Dislike"].Add(command);
                }
                else if (command == "comment")
                {
                    var commentator = tokens[2];
                    int commandLength = command.Length + post.Length + commentator.Length + 3;
                    var comment = input.Substring(commandLength);
                    if (!socialMediaDictionary[post].ContainsKey(commentator))
                    {
                        socialMediaDictionary[post][commentator] = new List<string>();
                    }

                    socialMediaDictionary[post][commentator].Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var post in socialMediaDictionary)
            {
                var likes = 0;
                var dislikes = 0;
                var commentators = post.Value;
                foreach (var item in post.Value)
                {
                    if (item.Key == "Like")
                    {
                        likes = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }
                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                bool noCommentsOnPost = true;
                foreach (var comment in commentators)
                {
                    if (comment.Key != "Like" && comment.Key != "Dislike")
                    {
                        noCommentsOnPost = false;
                        foreach (var word in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {word}");
                        }
                    }
                }

                if (noCommentsOnPost)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
      