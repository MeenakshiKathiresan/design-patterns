using System;
namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class FileContentPrinter
	{
		public FileContentPrinter()
		{

		}
		public static void PrintContent()
		{
			Console.WriteLine("Please enter file path");

			string filepath = Console.ReadLine();

			string ext = Path.GetExtension(filepath);
			IPrintableFile file;
			switch (ext)
			{
				case ".txt": file = new TXTPrintableFile(filepath); break;
				case ".csv": file = new CSVPrintableFile(filepath); break;
				default: Console.WriteLine("File not supported"); return;
			}

			Console.WriteLine(file.PrintFile());

			Console.WriteLine("Do you wish to read another file? y or n");
			bool readAgain = Console.ReadLine() == "y";

			if (readAgain) PrintContent();
			else Console.ReadLine();
        }
	}
}

