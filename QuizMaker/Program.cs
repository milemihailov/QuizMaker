namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;
        public const int MAX_QUESTIONS = 4;


        public static readonly Random rng = new Random();
        static void Main(string[] args)
        {

            List<QuizDatabase> Quiz = new List<QuizDatabase>();

            Logic.GetData(Quiz);

            int correctAnswers = Logic.PlayGame(Quiz);

            Console.WriteLine($"You had {correctAnswers} correct answers.");

        }
    }
}


