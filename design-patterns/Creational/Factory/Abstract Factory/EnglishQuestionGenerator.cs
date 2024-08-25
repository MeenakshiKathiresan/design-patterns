using System;
namespace design_patterns.Creational.Factory.AbstractFactory
{
	public class EnglishQuestionGenerator : IQuestionGenerator
	{
        Dictionary<string, string> questionAndAnswer;

        public EnglishQuestionGenerator()
		{
            questionAndAnswer = new Dictionary<string, string>
            {
                {"What is the past tense of 'go'?", "went"},
                {"What is the plural of foot", "feet"},
                {"What is the 5 letter antonym of big", "small"},
                {"What is the correct spelling - 'receive' or 'recieve'?", "receive" },
                {"What is the past tense of 'think'?", "thought"},
                {"What is the plural of phenomenon", "phenomena"},
            };

        }

        public string GenerateQuestion()
        {
            Random random = new Random();
            int index = random.Next(0, questionAndAnswer.Count());
            return questionAndAnswer.Keys.ToList()[index];
        }

        public bool ValidateAnswer(string question, string answer)
        {
            questionAndAnswer.TryGetValue(question, out string realAns);
            return answer == realAns;
        }
    }
}

