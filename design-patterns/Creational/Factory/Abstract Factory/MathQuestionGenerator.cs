using System;
using System.Data;

namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class MathQuestionGenerator : IQuestionGenerator
	{

        public string GenerateQuestion()
        {
            Random rnd = new Random();
            int firstNumber = rnd.Next(1, 100);
            int secondNumber = rnd.Next(1, 100);
            return $"{firstNumber} + {secondNumber}";
        }

        public bool ValidateAnswer(string question, string answer)
        {

            DataTable dt = new DataTable();
            var ans = dt.Compute(question, "");

            return int.Parse(answer) == Convert.ToInt32(ans);
        }
    }
}

