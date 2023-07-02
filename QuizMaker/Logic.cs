namespace QuizMaker
{
    internal class Logic
    {
        public static void GetData(List<Question> quizDatabase)
        {
            int count = 0;
            while (count < Program.MAX_QUESTIONS)
            {
                Question quiz = new Question();

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowEnterQuestionMessage);
                quiz.Questions = UiMethods.AskForStringInput();
                UiMethods.ClearDisplay();

                for (int i = 0; i < Program.MAX_NUM_OF_ANSWERS; i++)
                {
                    UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowOptionalAnswerMessage);
                    quiz.Answers.Add(UiMethods.AskForStringInput());
                }

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowRightAnswerMessage);
                quiz.RightAnswer = UiMethods.AskForStringInput();
                UiMethods.ClearDisplay();

                count++;
                quizDatabase.Add(quiz);
            }
        }
        public static int PlayGame(List<Question> quiz)
        {

            bool play = true;
            int points = 0;

            while (play)
            {
                int randomNum = Program.rng.Next(Program.MAX_QUESTIONS);

                UiMethods.ClearDisplay();

                UiMethods.ShowQuizData(quiz[randomNum]);

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowOptionalAnswerMessage);
                string ranswer = UiMethods.AskForStringInput();

                if (ranswer == quiz[randomNum].RightAnswer)
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowCorrectAnswer, randomNum, quiz, ranswer);
                    points++;
                }
                else
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowWrongAnswer, randomNum, quiz, ranswer);
                }

                UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowPlayMore, randomNum, quiz, ranswer);

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
