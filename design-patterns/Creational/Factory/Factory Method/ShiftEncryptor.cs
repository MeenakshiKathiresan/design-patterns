using System;

namespace design_patterns.Creational.Factory.FactoryMethod
{
    public class ShiftEncryptor : IEncryptor
    {
        private readonly int _shift;
        private const int AlphabetSize = 26;

        public ShiftEncryptor(int shift)
        {
            _shift = shift;
        }

        public string Decrypt(string text)
        {
            text = text.ToLower();
            char[] dText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsLetter(ch))
                {
                    char offset = 'a';
                    // Adjust for negative modulus
                    dText[i] = (char)((((ch - offset) - _shift + AlphabetSize) % AlphabetSize) + offset);
                }
                else
                {
                    dText[i] = ch; // Leave non-letter characters unchanged
                }
            }

            return new string(dText);
        }

        public string Encrypt(string text)
        {
            text = text.ToLower();
            char[] eText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsLetter(ch))
                {
                    char offset = 'a';
                    // Adjust for negative modulus
                    eText[i] = (char)((((ch - offset) + _shift + AlphabetSize) % AlphabetSize) + offset);
                }
                else
                {
                    eText[i] = ch; // Leave non-letter characters unchanged
                }
            }

            return new string(eText);
        }
    }
}
