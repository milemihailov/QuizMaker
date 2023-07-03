namespace QuizMaker
{
    internal class UiMethods
    {

        public enum ShowResults
        {
            ShowQuestion,
            ShowOptionalAnswer,
            ShowCorrectAnswer,
            ShowWrongAnswer,
            ShowPlayMore
        }

        public enum ShowMessages
        {
            ShowEnterQuestionMessage,
            ShowOptionalAnswerMessage,
            ShowRightAnswerMessage
        }


        public static void ShowInputMessage(ShowMessages options)
        {
            switch (options)
            {
                case ShowMessages.ShowEnterQuestionMessage:
                    Console.WriteLine("Enter your question:");
                    break;
                case ShowMessages.ShowOptionalAnswerMessage:
                    Console.WriteLine("Enter your answers:");
                    break;
                case ShowMessages.ShowRightAnswerMessage:
                    Console.WriteLine("Enter the right answer:");
                    break;
            }
        }

        public static void ShowCorrectAnswers(int correctAnswers)
        {
            Console.Clear();
            Console.WriteLine($"You had {correctAnswers} correct answers.");
        }

        public static string AskForStringInput()
        {
            string input = Console.ReadLine();

            while (int.TryParse(input, out int answer) || string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You need to enter text");
                input = Console.ReadLine();
            }
            return input;
        }


        public static char AskForCharInput()
        {
            return Console.ReadKey().KeyChar;
        }


        public static void ShowQuizData(Question quiz)
        {
            Console.WriteLine($"{quiz.Questions} | {quiz.AnswersString()}{quiz.RightAnswer}");
        }


        public static void ClearDisplay()
        {
            Console.Clear();
        }


        public static void ShowResultsMessage(ShowResults options, int randomNum, List<Question> quiz, string ranswer)
        {
            switch (options)
            {
                case ShowResults.ShowQuestion:
                    Console.Write($"{quiz[randomNum].Questions} | ");
                    break;
                case ShowResults.ShowCorrectAnswer:
                    Console.WriteLine("You got it right!");
                    Console.Write($"The right answer was: {ranswer} \n");
                    break;
                case ShowResults.ShowWrongAnswer:
                    Console.WriteLine("Wrong Answer!");
                    break;
                case ShowResults.ShowPlayMore:
                    Console.WriteLine("Play more? y/n");
                    break;
            }
        }
    }
}
