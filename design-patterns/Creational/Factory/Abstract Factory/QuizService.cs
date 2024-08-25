using System;
using design_patterns.Creational.Factory.FactoryMethod;

namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class QuizService
	{
		int currentScore = 0;

		public void StartQuiz()
		{
			IQuizFactory englishQuiz = new EnglishQuiz();
			IQuizFactory mathQuiz = new MathQuiz();

            Console.WriteLine("Press 1 for math quiz and 2 for english quiz");
            string quizType = Console.ReadLine();
			string question;

			IQuizFactory currentFactory;

            if (quizType == "1")
			{
				question = mathQuiz.questionGenerator.GenerateQuestion();
				currentFactory = mathQuiz;

            }
			else if(quizType == "2")
			{
				question = englishQuiz.questionGenerator.GenerateQuestion();
				currentFactory = englishQuiz;
            }
			else
			{
                Console.WriteLine("Enter a valid input");
				return;
            }


            Console.WriteLine(question);
			string ans = Console.ReadLine();

			bool isCorrect = currentFactory.questionGenerator.ValidateAnswer(question, ans);
			currentScore = currentFactory.scoreKeeper.UpdateScore(isCorrect, currentScore);

			if (isCorrect)
            {
				Console.WriteLine("That's right!!");
			}
			else
			{
				Console.WriteLine("Oops.. better luck next time..");
			}
			Console.WriteLine($"Your current score is {currentScore}");

			StartQuiz();

        }
	}
}

