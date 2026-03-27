using System.Security.Cryptography.X509Certificates;

namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating and Initializing an array of Question objects
            Question[] questions = new Question[] {
                new Question(
                    "What is the capital of Germany?",
                    ["Paris", "Berlin", "London", "Madrid" ],
                    1
                ),
                new Question(
                    "What is 2 + 2",
                    ["2", "4", "3", "8" ],
                    1
                ),
                new Question(
                    "Who wrote 'Hamlet'",
                    ["Goethe", "Austen", "Shakespeare", "Dickens" ],
                    2
                )

            };

            //Making an instance of a quiz object with questions array as parameter
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadKey();
        }
    }
}
