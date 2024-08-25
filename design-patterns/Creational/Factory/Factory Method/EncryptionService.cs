using System;
using design_patterns.Creational.Factory.SimpleFactory;

namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class EncryptionService
	{
        public static void StartEncryptor()
        {

            CaesarEncryptorFactory caesarEncryptorFactory = new CaesarEncryptorFactory();
            IEncryptor encryptor = caesarEncryptorFactory.CreateEncryptor(10);

            ShiftEncryptorFactory shiftEncryptorFactory = new ShiftEncryptorFactory();
            IEncryptor encryptor2 = shiftEncryptorFactory.CreateEncryptor(10);

            Console.WriteLine("Please enter the text you want to encrypt");
            string textToEncrypt = Console.ReadLine();
            Console.WriteLine(encryptor.Encrypt(textToEncrypt));


            Console.WriteLine("Please enter the text you want to decrypt");
            string textToDecrypt = Console.ReadLine();
            Console.WriteLine(encryptor.Decrypt(textToDecrypt));

            Console.WriteLine("Please enter the text you want to encrypt with shift encryption");
            string textToEncrypt2 = Console.ReadLine();
            Console.WriteLine(encryptor2.Encrypt(textToEncrypt2));


            Console.WriteLine("Please enter the text you want to decrypt with shift decryption");
            string textToDecrypt2 = Console.ReadLine();
            Console.WriteLine(encryptor2.Decrypt(textToDecrypt2));

            StartEncryptor();
        }
    }
}

