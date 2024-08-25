using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public interface IQuestionGenerator
	{
		public string GenerateQuestion();
		public bool ValidateAnswer(string question, string answer);
	}
}

