using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public interface IEncryptorFactory
	{
		IEncryptor CreateEncryptor(int shift);
	}
}

