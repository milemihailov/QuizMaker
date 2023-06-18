namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;
        public const int MAX_QUESTIONS = 4;

        static void Main(string[] args)
        {
            List<Question> QuizDatabase = new List<Question>();



            int count = 0;
            while (count < MAX_QUESTIONS)
            {
                Question Quiz = new Question();

                UiMethods.ShowInputMessage(UiMethods.Options.Question);
                Quiz.Questions = UiMethods.AskForInput();
                UiMethods.ClearDisplay();

                for (int i = 0; i < MAX_NUM_OF_ANSWERS; i++)
                {
                    UiMethods.ShowInputMessage(UiMethods.Options.OptionalAnswer);
                    Quiz.Answers.Add(UiMethods.AskForInput());
                }

                UiMethods.ShowInputMessage(UiMethods.Options.RightAnswer);
                Quiz.RightAnswer = UiMethods.AskForInput();
                UiMethods.ClearDisplay();

                count++;
                QuizDatabase.Add(Quiz);

            }

            //foreach (Question Quiz in QuizDatabase)
            //{
            //    Console.Write($"{Quiz.Questions} | ");
            //    Console.Write(Quiz.AnswersString());
            //    Console.Write($"{Quiz.RightAnswer} \n");
            //}

        }
    }

}


