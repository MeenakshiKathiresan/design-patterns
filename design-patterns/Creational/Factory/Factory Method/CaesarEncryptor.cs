using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class CaesarEncryptor : IEncryptor
	{
        int _shift;

		public CaesarEncryptor(int shift)
		{
            _shift = shift;
		}

        public string Decrypt(string text)
        {
            text = text.ToLower();
            int a = 'a';

            char[] dText = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                dText[i] = (char)((ch - _shift - a) % 26 + a);
            }

            return new string(dText);
        }

        public string Encrypt(string text)
        {
            text = text.ToLower();
            int a = 'a';

            char[] eText = text.ToCharArray();

            for (int i = 0; i <text.Length; i++)
            {
                char ch = text[i];
                eText[i] = (char)((ch + _shift - a) % 26 + a);
            }

            return new string(eText);
        }
    }
}

