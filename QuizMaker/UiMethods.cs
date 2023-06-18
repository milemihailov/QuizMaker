namespace QuizMaker
{
    internal class UiMethods
    {

        public enum Options
        {
            Question,
            OptionalAnswer,
            RightAnswer
        }
        public static void ShowInputMessage(Options options)
        {
            switch (options)
            {
                case Options.Question:
                    Console.WriteLine("Enter your question:");
                    break;
                case Options.OptionalAnswer:
                    Console.WriteLine("Enter your answers:");
                    break;
                case Options.RightAnswer:
                    Console.WriteLine("Enter the right answer:");
                    break;
            }
        }

        public static string AskForInput()
        {
            return Console.ReadLine().ToString();
        }

        public void ShowQuizData(Question quiz)
        {
            Console.WriteLine($"{quiz.Questions} | {quiz.AnswersString()}{quiz.RightAnswer}");
        }

        public static void ClearDisplay()
        {
            Console.Clear();
        }
    }
}
