using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while(inputLine!="go go go")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string topic = inputParams[0];
                string courseName = inputParams[1];
                string judgeContest = inputParams[2];
                List <string> problems = inputParams.Skip(3).ToList(); 

                Exercise exercise = new Exercise();
                exercise.Topic = topic;
                exercise.CourseName = courseName;
                exercise.JudgeContestLink = judgeContest;
                exercise.Problems = problems;

                exercises.Add(exercise);
                
                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int count = 1;
                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;

                }

            }

            
        }

        class Exercise
        {


            public String Topic { get; set; }
            public String CourseName { get; set; }
            public String JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }
    }
}
