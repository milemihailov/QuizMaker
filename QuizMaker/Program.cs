namespace QuizMaker
{
    internal class Program
    {
        public const int MAX_NUM_OF_ANSWERS = 3;

        static void Main(string[] args)
        {
            QuizDatabase Quiz = new QuizDatabase();

            Console.WriteLine("Enter your question:");
            Quiz.Question.Add(Console.ReadLine().ToString());

            for (int i = 0; i < MAX_NUM_OF_ANSWERS; i++)
            {
                Console.WriteLine("Enter your answers:");
                Quiz.Answers.Add(Console.ReadLine().ToString());
            }

            Console.WriteLine("Enter the right answer:");
            Quiz.RightAnswer = Console.ReadLine().ToString();

        }
    }
}