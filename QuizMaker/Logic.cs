﻿namespace QuizMaker
{
    internal class Logic
    {
        public static void GetData(List<Question> QuizDatabase)
        {
            int count = 0;
            while (count < Program.MAX_QUESTIONS)
            {
                Question Quiz = new Question();

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowEnterQuestionMessage);
                Quiz.Questions = UiMethods.AskForStringInput();
                UiMethods.ClearDisplay();

                for (int i = 0; i < Program.MAX_NUM_OF_ANSWERS; i++)
                {
                    UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowOptionalAnswerMessage);
                    Quiz.Answers.Add(UiMethods.AskForStringInput());
                }

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowRightAnswerMessage);
                Quiz.RightAnswer = UiMethods.AskForStringInput();
                UiMethods.ClearDisplay();

                count++;
                QuizDatabase.Add(Quiz);
            }
        }
        public static int PlayGame(List<Question> Quiz)
        {

            bool play = true;
            int points = 0;

            while (play)
            {
                int randomNum = Program.rng.Next(Program.MAX_QUESTIONS);

                UiMethods.ClearDisplay();

                UiMethods.ShowQuizData(Quiz[randomNum]);

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowOptionalAnswerMessage);
                string ranswer = UiMethods.AskForStringInput();

                if (ranswer == Quiz[randomNum].RightAnswer)
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowCorrectAnswer, randomNum, Quiz, ranswer);
                    points++;
                }
                else
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowWrongAnswer, randomNum, Quiz, ranswer);
                }

                UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowPlayMore, randomNum, Quiz, ranswer);

                char playAgain = UiMethods.AskForCharInput();

                if (playAgain == 'y')
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }
            return points;
        }
    }
}
