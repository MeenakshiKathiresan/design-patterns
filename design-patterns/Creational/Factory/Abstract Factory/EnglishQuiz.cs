using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
    public class EnglishQuiz : IQuizFactory
    {
        public EnglishQuiz()
        {
            questionGenerator = new EnglishQuestionGenerator();
            scoreKeeper = new EnglishScoreKeeper();
        }
        public IQuestionGenerator questionGenerator { get; set; }
        public IScoreKeeper scoreKeeper { get; set; }
    }
}

