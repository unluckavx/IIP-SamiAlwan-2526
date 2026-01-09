using System;

class Program
{
    static void Main()
    {
        double saldo = 1000.0;
		
        Console.WriteLine(@"
--- CARWASH ODISEE ---");
        
        {
         
            Console.WriteLine("(a) Wasprogramma kiezen");
            Console.WriteLine("(b) Saldo opladen");
			Console.WriteLine("(q) Betalen en starten");
			Console.WriteLine("(s) Volledig stoppen (geld terug) ");
			
			Console.WriteLine();
			Console.WriteLine("Huidige saldo: € 0,00");
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine("Gekozen programma: Geen");
			Console.WriteLine("----------------------------------------------");
			Console.Write("Maak uw keuze: ");
            string keuze = Console.ReadLine();

            switch (keuze)
            {
                case "a":
					Console.WriteLine();
					Console.WriteLine(@"--- KIES UW PROGRAMMA --- ");
                    char schepijs = Convert.ToChar(Console.ReadLine());

					Console.WriteLine("1) Basic (€ 10,00)");
					int Basic = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("2) Deluxe (€ 15,00)");
					int Deluxe = Convert.ToInt32(Console.ReadLine());
                
                    if (schepijs % 20 != 0 && schepijs % 50 != 0)
                    {
                        Console.Write("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen): ");
						string vanille = Console.ReadLine();
						 Console.Write("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen): ");
						string aardbei = Console.ReadLine();
						Console.Write("Vanille, aardbei, chocolade, mokka; laat leeg om te stoppen): ");
						string chocolade = Console.ReadLine();
						Console.WriteLine();
						Console.Write("Wil je er slagrooms bij (j/n)?: ");
						char slagrooms = Console.ReadKey().KeyChar;
						Console.WriteLine();
						Console.WriteLine("Houder: ");
						Console.WriteLine($"Bollen: {vanille} {aardbei} {chocolade}");
						Console.WriteLine($"Slagrooms: {slagrooms}");
						Console.WriteLine("Prijs: ");
						
                    }
                    else if (schepijs > saldo)
                    {
                        Console.WriteLine("fout: onvoldoende saldo");
                    }
                    else
                    {
                        saldo -= schepijs;
                        Console.WriteLine($"schepijshijpijs ok - het nieuw saldo is {saldo:C}");
                    }
                    break;

                case "b":
					
					Console.WriteLine();
                    Console.Write("Hoeveel geld werpt u in? ");
					double cijfertje2 = Convert.ToDouble(Console.ReadLine());
					
					
				
					string cijfertje1 = Console.ReadLine();
					
					Console.WriteLine("Druk op Enter..."); 
					string dag = Console.ReadLine();  
					Console.Clear();
					
 					
					
                    break;
					
					
				    case "q":
					
					Console.WriteLine();
                    Console.WriteLine(@"--- AFREKENING --- ");
					string afrekening = Console.ReadLine();
					Console.WriteLine("Wasbeurt: Basic");
					string wasbeurt = Console.ReadLine();
					Console.WriteLine("Prijs: € 10,00");
					string prijs = Console.ReadLine();
					Console.WriteLine("Fout: Kies eerst een wasprogramma.");
					
				
					
 					
					
                    break;
					
					case "s":
					
					Console.WriteLine();
                    Console.WriteLine("U krijgt € 5,00 terug.");
					Console.WriteLine("Bedankt voor uw bezoek!");
					
					Console.WriteLine("Druk op Enter..."); 
					string dagdag = Console.ReadLine();  
					Console.Clear();
					
                    break;
					
					
					
					
					
					
					
					
					
					
					
					default:
					Console.WriteLine("Fout: Alleen veelvouden van € 0,50 toegelaten.");
					
                    break;
            }
        }
    }
}
