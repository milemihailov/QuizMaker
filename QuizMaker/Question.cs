namespace QuizMaker
{
    public class Question
    {
        public string Questions { get; set; }

        public List<string> Answers = new List<string>();
        public string RightAnswer { get; set; }

        public string AnswersString()
        {
            string answers = "";
            foreach (string word in Answers)
            {
                answers += word + " | ";
            }
            return answers;
        }
    }
}
