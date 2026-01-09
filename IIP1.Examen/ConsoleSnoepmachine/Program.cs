using System;

	namespace ConsoleAtm
	{
		internal class Program
		{
			static void Main(string[] args)
			{
			
			const int MaxAfhaling = 200;
			decimal saldo = 500.00M;  
			Console.WriteLine(@"*******************
Ijssalon 't Bolleke
************************");			
			
		
			Console.WriteLine();
			Console.WriteLine("Wat wil je bestellen:");
			Console.WriteLine("a) Schepijs");
			Console.WriteLine("b) smoxre");
			
			Console.WriteLine();
			
			Console.Write("Maak je keuze: ");
			char keuze = Convert.ToChar(Console.ReadLine()); 
			
		   
			string aardbei = Console.ReadLine();
			switch (keuze)
			{
				case 'a':
					Console.Write("Wil je een hoorntje of een bakje? (h/b): ");
					char Schepijs = Convert.ToChar(Console.ReadLine());
					if (Schepijs <= 0)
				   {
						Console.WriteLine("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen):");
			       }   
					else if (Schepijs > MaxAfhaling || Schepijs > saldo)
		           {     
						Console.WriteLine("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen):");
	               }
					else if (Schepijs % 10 != 0 || Schepijs == 10 || Schepijs == 30)
	               {
						Console.Write("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen):");
		           }
					else
		           {
						saldo -= Schepijs;
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