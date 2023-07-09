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

        public static readonly Dictionary<ShowMessages, string> messageTexts = new Dictionary<ShowMessages, string>()
        {
            { ShowMessages.ShowEnterQuestionMessage,"Enter your question:" },
            { ShowMessages.ShowOptionalAnswerMessage, "Enter your answers:" },
            { ShowMessages.ShowRightAnswerMessage, "Enter the right answer:" }

        };

        public static void ShowInputMessage(ShowMessages options)
        {
            Console.WriteLine(messageTexts[options]);
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
            Console.WriteLine($"{quiz.Questions} | {quiz.AnswersString()}");
        }


        public static void ClearDisplay()
        {
            Console.Clear();
        }

        public static void ShowQuestion(List<Question> quiz, int randomNum)
        {
            Console.Write($"{quiz[randomNum].Questions} | ");
        }

        public static void ShowCorrectAnswer(string ranswer)
        {
            Console.WriteLine("You got it right!");
            Console.Write($"The right answer was: {ranswer} \n");
        }

        public static readonly Dictionary<ShowResults, string> resultsTexts = new Dictionary<ShowResults, string>()
        {
            { ShowResults.ShowWrongAnswer, "Wrong Answer!" },
            { ShowResults.ShowPlayMore, "Play more? y/n" }
        };

        public static void ShowResultsMessage(ShowResults options)
        {
            Console.WriteLine(resultsTexts[options]);
        }
    }
}
