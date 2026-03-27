using QuizProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject
{
    internal class Quiz
    {
        //Declaring an aray of Question Objects (EXAMPLE questions[2] = {question_object1, question_object2})
        private Question[] questions;
        private int score;


        //Quiz constructor (Sets the questions of the program to the quests of the Quiz)
        public Quiz(Question[] questions)
        {
            this.questions = questions;
            score = 0;
        }


        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1;
            foreach (Question question in questions)  
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (!question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }else
                {
                    Console.WriteLine("Correct");
                    score++;
                }
            }
            ShowResault();
        }

        private void ShowResault()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is: {score} out of {questions.Length}");

            double percentage = (double)score / questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // changes the text color
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor(); // resets the foreground (text) color
                Console.WriteLine($". {question.Answers[i]}");
            }

        }


        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return choice - 1; // adjust to 0-indexed array

        }

    }
}