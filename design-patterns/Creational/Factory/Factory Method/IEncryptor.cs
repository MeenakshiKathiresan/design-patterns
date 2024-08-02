using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public interface IEncryptor
	{
		public string Encrypt(string text);
		public string Decrypt(string text);
	}
}

