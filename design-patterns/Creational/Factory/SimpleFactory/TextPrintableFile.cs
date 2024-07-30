using System;
namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class TextPrintableFile : IPrintableFile
	{
		string filepath;

		public TextPrintableFile(string _filepath)
		{
			filepath = _filepath;
		}

        public string PrintFile()
        {
			string content = File.ReadAllText(filepath);
			return content;
        }
    }
}

