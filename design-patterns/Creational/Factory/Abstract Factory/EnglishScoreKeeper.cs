using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
    public class EnglishScoreKeeper : IScoreKeeper
    {
        int streak = 0;
        int correctAnswerScore = 2;
        public int UpdateScore(bool isCorrect, int currentScore)
        {
            if (isCorrect)
                streak += 1;
            else
                streak = 0;

            currentScore += streak * correctAnswerScore;
            return currentScore;
        }
    }
}

