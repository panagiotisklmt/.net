using System;
using System.Collections.Generic;
using System.Text;

namespace QuizProject
{
    internal class Question
    {
        //Getters and Setters
        public String QuestionText { get; set; } 
        public String[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }


        //Default constructor, each Question has a string for the text, an array of strings for the answers and an int for the index of the right answer
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        //Method for checking if the user input is correct
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
