namespace QuizMaker
{
    internal class GamePlay
    {
        public static void Game(List<Question> Quiz)
        {

            bool play = true;

            while (play)
            {
                int randomNum = Program.rng.Next(Program.MAX_QUESTIONS);

                UiMethods.ClearDisplay();
                Console.Write($"{Quiz[randomNum].Questions} | ");
                Console.Write(Quiz[randomNum].AnswersString());

                //UiMethods.ShowQuizData(Quiz);

                UiMethods.ShowInputMessage(UiMethods.ShowMessages.ShowOptionalAnswerMessage);
                string ranswer = UiMethods.AskForStringInput();

                if (ranswer == Quiz[randomNum].RightAnswer)
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowCorrectAnswer, randomNum, Quiz, ranswer);
                }
                else
                {
                    UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowWrongAnswer, randomNum, Quiz, ranswer);
                }

                UiMethods.ShowResultsMessage(UiMethods.ShowResults.ShowPlayMore, randomNum, Quiz, ranswer);

                char playAgain = UiMethods.AskForCharInput();

                if (playAgain == 'y')
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }
        }
    }
}
