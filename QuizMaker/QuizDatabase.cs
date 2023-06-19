namespace QuizMaker
{
    internal class QuizDatabase
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
    }
}
