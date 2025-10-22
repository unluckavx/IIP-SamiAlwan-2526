using System;

	namespace ConsoleAtm
	{
		internal class Program
		{
			static void Main(string[] args)
			{
			
			
			
			const int MaxAfhaling = 200;
			decimal saldo = 500.00M;  // M voor decimal 
			string header = @"Bankautomaat
============";
			Console.WriteLine(header);
			
			
			Console.WriteLine();
			Console.WriteLine($"huidig saldo: {saldo:C2}");
			Console.WriteLine();
			Console.WriteLine("a. afhaling");
			Console.WriteLine("b. storting");
			Console.WriteLine("c. stoppen");
			Console.WriteLine();
			
			Console.Write("je keuze: ");
			char keuze = Console.ReadKey(true).KeyChar; 
			Console.WriteLine($"je keuze: {keuze}");
			Console.WriteLine();
			
			switch (keuze)
			{
				case 'a':
					Console.Write("welk bedrag wil je afhalen: ");
					decimal bedragAfhalen = Convert.ToDecimal(Console.ReadLine());
					if (bedragAfhalen <= 0)
				   {
						Console.WriteLine("fout: bedrag moet positief zijn");
			       }
					else if (bedragAfhalen > MaxAfhaling || bedragAfhalen > saldo)
		           {
						Console.WriteLine("fout: je kan maximaal 200 afhalen");
	               }
					else if (bedragAfhalen % 10 != 0 || bedragAfhalen == 10 || bedragAfhalen == 30)
	               {
						Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
		           }
					else
		           {
						saldo -= bedragAfhalen;
						Console.WriteLine($"afhaling ok – het nieuw saldo is {saldo:C2}");
		           }
					break;

				case 'b':
					Console.Write("welk bedrag wil je storten: ");
					decimal bedragStorten = Convert.ToDecimal(Console.ReadLine());
					saldo += bedragStorten;
					Console.WriteLine();
					Console.WriteLine($"storting ok – het nieuw saldo is {saldo:C2}");
					break;
				case 'c':
					Console.WriteLine("bedankt en tot ziens");
					break;

				default:
					Console.WriteLine("ongeldige keuze");
					break;
					
		      }

            
			Console.ReadLine();
        }
    }
}