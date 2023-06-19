namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;
        public const int MAX_QUESTIONS = 4;


        public static readonly Random rng = new Random();
        static void Main(string[] args)
        {

            List<Question> QuizDatabase = new List<Question>();

            int count = 0;
            while (count < MAX_QUESTIONS)
            {
                Question Quiz = new Question();

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowEnterQuestionMessage);
                Quiz.Questions = UiMethods.AskForStringInput();
                UiMethods.ClearDisplay();

                for (int i = 0; i < MAX_NUM_OF_ANSWERS; i++)
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

            GamePlay.Game(QuizDatabase);

        }
    }

}


