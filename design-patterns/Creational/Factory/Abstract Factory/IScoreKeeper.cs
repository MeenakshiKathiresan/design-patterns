using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public interface IScoreKeeper
	{
		public int UpdateScore(bool isCorrect, int currentScore);
	}
}

