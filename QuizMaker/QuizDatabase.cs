namespace QuizMaker
{
    internal class QuizDatabase
    {
        public List<string> Answers = new List<string>();
        public List<string> Question = new List<string>();
        public string RightAnswer { get; set; }
    }
}
