﻿namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;
        public const int MAX_QUESTIONS = 4;


        public static readonly Random rng = new Random();
        static void Main(string[] args)
        {

            List<Question> quiz = new List<Question>();

            Logic.GetData(quiz);

            int correctAnswers = Logic.PlayGame(quiz);

            UiMethods.ShowCorrectAnswers(correctAnswers);

        }
    }
}


