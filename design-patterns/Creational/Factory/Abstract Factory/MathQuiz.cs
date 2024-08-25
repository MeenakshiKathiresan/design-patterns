using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class MathQuiz : IQuizFactory
	{
		public MathQuiz()
		{
			questionGenerator = new MathQuestionGenerator();
			scoreKeeper = new MathScoreKeeper();
		}

        public IQuestionGenerator questionGenerator { get; set; }
        public IScoreKeeper scoreKeeper { get; set; }
    }
}

