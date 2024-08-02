using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class ShiftEncryptorFactory :IEncryptorFactory
	{

        public IEncryptor CreateEncryptor(int shift)
        {
            return new ShiftEncryptor(shift);
        }
    }
}

