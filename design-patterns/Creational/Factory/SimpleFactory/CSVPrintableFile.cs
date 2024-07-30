using System;
namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class CsvPrintableFile : IPrintableFile
	{
		public CsvPrintableFile(string _filepath)
		{
            filepath = _filepath;
		}

        public string filepath;

        public string PrintFile()
        {
            string[] fullContent = File.ReadAllLines(filepath);
            string content = "";

            foreach (string line in fullContent)
            {
                content += $"{line} \n";
            }

            return content;
        }
    }
}

