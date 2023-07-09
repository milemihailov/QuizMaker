namespace QuizMaker
{
    internal class Logic
    {
        public static List<Question> GetData()
        {
            List<Question> quizDatabase = new List<Question>();
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
            return quizDatabase;
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
                    UiMethods.ShowCorrectAnswer(ranswer);
                    points++;
                }
                else
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowWrongAnswer);
                }

                UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowPlayMore);

                char playAgain = UiMethods.AskForCharInput();

                play = playAgain == 'y';
            }
            return points;
        }
    }
}
