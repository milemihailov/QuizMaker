namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;

        static void Main(string[] args)
        {
            QuizDatabase Quiz = new QuizDatabase();

            UiMethods.ShowInputMessage(UiMethods.Options.Question);
            Quiz.Question.Add(UiMethods.AskForInput());

            for (int i = 0; i < MAX_NUM_OF_ANSWERS; i++)
            {
                UiMethods.ShowInputMessage(UiMethods.Options.OptionalAnswer);
                Quiz.Answers.Add(UiMethods.AskForInput());
            }

            UiMethods.ShowInputMessage(UiMethods.Options.RightAnswer);
            Quiz.RightAnswer = UiMethods.AskForInput();

        }
    }
}
