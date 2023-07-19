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

        public static readonly Dictionary<ShowResults, string> resultsTexts = new Dictionary<ShowResults, string>()
        {
            { ShowResults.ShowWrongAnswer, "Wrong Answer!" },
            { ShowResults.ShowPlayMore, "Play more? y/n" }
        };

        public static void ShowInputMessage(ShowMessages options)
        {
            Console.WriteLine(messageTexts[options]);
        }


        public static void ShowResultsMessage(ShowResults options)
        {
            Console.WriteLine(resultsTexts[options]);
        }

        /// <summary>
        /// Shows the correct answer
        /// </summary>
        /// <param name="correctAnswers"></param>
        public static void ShowCorrectAnswers(int correctAnswers)
        {
            Console.Clear();
            Console.WriteLine($"You had {correctAnswers} correct answers.");
        }

        /// <summary>
        /// Asks the user to enter string as input
        /// </summary>
        /// <returns>String</returns>
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

        /// <summary>
        ///  Asks the user to enter character as input
        /// </summary>
        /// <returns>Character</returns>
        public static char AskForCharInput()
        {
            return Console.ReadKey().KeyChar;
        }


        /// <summary>
        /// Asks the user for integer between 1 and 2
        /// </summary>
        /// <returns></returns>
        public static int AskForQuizerModeInput()
        {
            bool waitForNum = false;
            int num = 0;

            while (!waitForNum)
            {
                string inputNum = Console.ReadLine();
                waitForNum = int.TryParse(inputNum, out num);

                if (!waitForNum)
                {
                    Console.WriteLine("You need to enter a number.");
                }
                if (num > Program.QUIZER_MODE_PLAY_GAME || num < Program.QUIZER_MODE_DATA_ENTERING)
                {
                    Console.WriteLine($"Enter number between {Program.QUIZER_MODE_DATA_ENTERING} and {Program.QUIZER_MODE_PLAY_GAME}");
                    waitForNum = false;
                }
            }
            return num;
        }

        /// <summary>
        ///  Asks the user for integer
        /// </summary>
        /// <returns></returns>

        public static int AskForIntInput()
        {
            bool waitForNum = false;
            int num = 0;

            while (!waitForNum)
            {
                string inputNum = Console.ReadLine();
                waitForNum = int.TryParse(inputNum, out num);

                if (!waitForNum)
                {
                    Console.WriteLine("You need to enter a number.");
                }
            }
            return num;
        }


        /// <summary>
        /// Shows the question and the answers
        /// </summary>
        /// <param name="quiz"></param>
        public static void ShowQuizData(Question quiz)
        {
            Console.WriteLine($"{quiz.Questions} | {quiz.AnswersString()}");
        }


        /// <summary>
        /// Clears display
        /// </summary>
        public static void ClearDisplay()
        {
            Console.Clear();
        }


        /// <summary>
        /// Shows correct answer if you have guessed it
        /// </summary>
        /// <param name="ranswer"></param>
        public static void ShowCorrectAnswer(string ranswer)
        {
            Console.WriteLine("You got it right!");
            Console.Write($"The right answer was: {ranswer} \n");
        }

        /// <summary>
        /// Asks the user if he wants to play or enter hes own questions first
        /// </summary>
        public static void ShowPlayOrEnterDataQuestion()
        {
            Console.WriteLine("Would you like to play or enter your questions?");
            Console.WriteLine($"{Program.QUIZER_MODE_DATA_ENTERING}.Enter questions\n{Program.QUIZER_MODE_PLAY_GAME}.Play");
        }
    }
}
