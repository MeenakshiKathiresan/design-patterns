using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class MathScoreKeeper : IScoreKeeper
	{
		int correctAnswerScore = 10;
		int wrongAnswerScore = -5;

        public int UpdateScore(bool isCorrect, int currentScore)
        {
			if (isCorrect)
			{
				currentScore += correctAnswerScore;
			}
			else
			{
				currentScore -= wrongAnswerScore;
			}
			return currentScore;
        }
    }
}

