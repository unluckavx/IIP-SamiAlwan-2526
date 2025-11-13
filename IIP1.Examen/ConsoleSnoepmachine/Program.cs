using System;

namespace ConsoleAbonnement
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
	    // const veranderd nooit !      // prijs per drank en snoep 
		const decimal PrijsDrank = 2.00m;
		const decimal PrijsSnoep = 1.50m;
		
		decimal Saldo = 0m;
  		string keuze = "";
		
		Console.Clear(); 
		
		Console.WriteLine(@"SNOEPMACHINE");
		
		Console.WriteLine();
		Console.WriteLine("a. geld inwerpen");
		Console.WriteLine("b. drank kopen (2,00 euro) ({PrijsDrank:0.00} euro)");
		Console.WriteLine("c. snoep kopen (1,50 euro ) ({PrijsSnoep:0.00} euro)");
		Console.WriteLine("d. stoppen");
		
		Console.WriteLine();
		
		Console.WriteLine($"Huidige saldo: {Saldo:0.00} euro");
		Console.Write("Maak je keuze: ");
		
		keuze = Console.ReadLine().ToLower();
		
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
						Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
		           }
					else
		           {
						Saldo -= bedragAfhalen;
						Console.WriteLine($"afhaling ok – het nieuw saldo is {saldo:C2}");
		           }
					break;

				case 'b':
					Console.Write("welk bedrag wil je storten: ");
					decimal bedragStorten = Convert.ToDecimal(Console.ReadLine());
					Saldo += bedragStorten;
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
            

