using System;
namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class TXTPrintableFile : IPrintableFile
	{
		string filepath;

		public TXTPrintableFile(string _filepath)
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

