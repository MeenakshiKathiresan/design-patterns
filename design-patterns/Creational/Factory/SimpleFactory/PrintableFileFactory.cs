using System;
using static System.Net.Mime.MediaTypeNames;

namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class PrintableFileFactory
	{
		public IPrintableFile CreateFilePrinter(string filepath)
		{
            string ext = Path.GetExtension(filepath);
            IPrintableFile file;
            switch (ext)
            {
                case ".txt": file = new TextPrintableFile(filepath); break;
                case ".csv": file = new CsvPrintableFile(filepath); break;
                default: throw new Exception("File not supported."); 
            }
            return file;
        }
	}
}

