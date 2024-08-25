using System;
using design_patterns.Creational.Factory.FactoryMethod;

namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class QuizService
	{
		
		int currentScore = 0;

        IQuizFactory englishQuiz = new EnglishQuiz();
        IQuizFactory mathQuiz = new MathQuiz();

        public IQuizFactory GetQuizFactory(QuizType type)
		{
			switch (type)
			{
				case QuizType.english:
					return englishQuiz;
				case QuizType.math:
					return mathQuiz;
				default:
					return mathQuiz;
			}
		}

		public void DisplayFeedback(bool isCorrect)
        {
            if (isCorrect)
            {
                Console.WriteLine("That's right!!");
            }
            else
            {
                Console.WriteLine("Oops.. better luck next time..");
            }

            Console.WriteLine($"Your current score is {currentScore}");
        }


		public void StartQuiz()
		{
			try
			{
				Console.WriteLine($"Press {(int)QuizType.math} for math quiz and {(int)QuizType.english} for english quiz");
				QuizType quizType = (QuizType)int.Parse(Console.ReadLine());

				// Get factory based on type
				IQuizFactory quizFactory = GetQuizFactory(quizType);
				string question = quizFactory.questionGenerator.GenerateQuestion();

				Console.WriteLine(question);
				string ans = Console.ReadLine();

				bool isCorrect = quizFactory.questionGenerator.ValidateAnswer(question, ans);
				currentScore = quizFactory.scoreKeeper.UpdateScore(isCorrect, currentScore);

				DisplayFeedback(isCorrect);

				// loop again
				StartQuiz();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
        }
	}
    public enum QuizType
    { math = 1, english = 2 }
}

