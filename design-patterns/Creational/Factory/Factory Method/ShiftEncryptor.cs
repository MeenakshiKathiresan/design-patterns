using System;
namespace design_patterns.Creational.Factory.FactoryMethod
{
	public class ShiftEncryptor : IEncryptor
	{
        int _shift;
		public ShiftEncryptor(int shift)
		{
            _shift = shift;
		}

        public string Decrypt(string text)
        {

            text = text.ToLower();
            int a = 'a';

            char[] dText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                dText[i] = (char)(ch - (_shift * (i + 1) - a) % 26 + a);
            }

            return dText.ToString();
        }

        public string Encrypt(string text)
        {
            text = text.ToLower();
            int a = 'a';

            char[] eText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                eText[i] = (char)(ch + (_shift * (i+1) - a) % 26 + a);
            }

            return eText.ToString();
        }
    }
}

