using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class CaesarEncryptorFactory : IEncryptorFactory
	{

        public IEncryptor CreateEncryptor(int shift)
        {
            return new CaesarEncryptor(shift);
        }
    }
}

