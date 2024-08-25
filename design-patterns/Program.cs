using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple factory usage
            //design_patterns.Creational.Factory.SimpleFactory.FileContentPrinter.PrintContent();

            // factory method usage
            //design_patterns.Creational.Factory.FactoryMethod.EncryptionService.StartEncryptor();

            // abstract factory method usage
            var quiz = new design_patterns.Creational.Factory.AbstractFactory.QuizService();
            quiz.StartQuiz();
        }
    }
}
