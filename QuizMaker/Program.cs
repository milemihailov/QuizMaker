namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;
        public const int CHOICES = 2;

        public static readonly Random rng = new Random();
        static void Main(string[] args)
        {
            UiMethods.ShowPlayOrEnterDataQuestion();
            UiMethods.AskForIntInputBetween1and2();

            List<Question> quiz = new List<Question>();

            if (UiMethods.AskForIntInputBetween1and2() == 1)
            {
                quiz = Logic.GetData();
            }

            if (FileReadWrite.IsXmlFileMissing())
            {
                FileReadWrite.SerializeXmlFileToList(quiz);
            }

            FileReadWrite.SerializeListToXmlFile(quiz);

            int correctAnswers = Logic.PlayGame(quiz);

            UiMethods.ShowCorrectAnswers(correctAnswers);

        }
    }
}