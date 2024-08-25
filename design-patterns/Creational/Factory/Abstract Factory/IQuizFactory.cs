using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public interface IQuizFactory
	{

        public IQuestionGenerator questionGenerator { get; set; }
        public IScoreKeeper scoreKeeper { get; set; }
    }
}

