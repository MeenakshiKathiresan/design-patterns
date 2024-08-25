using System;
namespace design_patterns.Creational.Factory.SimpleFactory
{
	public class FileContentPrinter
	{
		public static void PrintContent()
		{
			Console.WriteLine("Please enter file path");
			string filepath = Console.ReadLine();

			PrintableFileFactory fileFactory = new PrintableFileFactory();
			IPrintableFile file = fileFactory.CreateFilePrinter(filepath);

			Console.WriteLine(file.PrintFile());

			Console.WriteLine("Do you wish to read another file? y or n");
			bool readAgain = Console.ReadLine() == "y";

			if (readAgain) PrintContent();
			else Console.ReadLine();
        }
	}
}

