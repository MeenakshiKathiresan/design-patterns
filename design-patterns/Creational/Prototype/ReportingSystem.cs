using System;
namespace design_patterns.Creational.Prototype
{
	public class ReportingSystem
	{
		public void DemonstrateConfigCopy()
		{
			ICopyable reportConfigDefault = new ReportConfiguration(12, "San serif", true);

			// apply same configuration to another report 
			ReportConfiguration reportConfigAccounts = (ReportConfiguration)reportConfigDefault.Copy();
			// can change only 1 parameter
			reportConfigAccounts.SetFont("Time New Roman");
			Console.WriteLine(reportConfigAccounts.GetConfigInfo());
			Console.ReadLine();

        }
	}
}

