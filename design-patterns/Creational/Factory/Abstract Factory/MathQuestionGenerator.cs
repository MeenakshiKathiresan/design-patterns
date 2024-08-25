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

            // evaluate question and get the actual answer
            DataTable dt = new DataTable();
            var realAnswer = dt.Compute(question, "");

            bool isNumeric  = int.TryParse(answer, out int userAnswer);
            if (isNumeric)
            {
                return userAnswer == Convert.ToInt32(realAnswer);
            }
            else
            {
                throw new Exception("Please enter a valid input");
            }
            

           
        }
    }
}

