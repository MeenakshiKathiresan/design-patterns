using System;
using design_patterns.Creational.Factory.SimpleFactory;

namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class EncryptionService
	{
        public static void StartEncryptor()
        {
            Console.WriteLine("Please enter the text you want to encrypt");
            string text = Console.ReadLine();

            CaesarEncryptorFactory caesarEncryptorFactory = new CaesarEncryptorFactory();
            IEncryptor encryptor = caesarEncryptorFactory.CreateEncryptor(10);

            Console.WriteLine(encryptor.Encrypt(text));


            Console.WriteLine("Please enter the text you want to decrypt");
            string textToDecrypt = Console.ReadLine();

            Console.WriteLine(encryptor.Decrypt(text));
            StartEncryptor();
        }
    }
}

