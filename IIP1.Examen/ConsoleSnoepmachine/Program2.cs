using System;

class Program
{
    static void Main()
    {
        double saldo = 1000.0;
		const double hoorntje = 0.5;
		const double bakje = 0.3;
		const double bol = 1;
		const int bollen = 3;
		
		double berekening = saldo * hoorntje * bakje * bol * bollen;
        

        Console.WriteLine(@"
********************************
	Ijssalon 't Bolleke
********************************");

        
        {
            Console.WriteLine();
            Console.WriteLine("Wat wil je betsellen:");
            Console.WriteLine("a) schepijs🍧");
            Console.WriteLine("b) smoothie🍹");
			Console.WriteLine();
			Console.Write("Maak je keuze: ");
            string keuze = Console.ReadLine().ToLower();

            switch (keuze)
            {
                case "a":
                    Console.Write("Wil je een hoorntje of een bakje? (h/b): ");
                    char schepijs = Convert.ToChar(Console.ReadLine());

                
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
                    Console.WriteLine("Je gebt gekozen voor een smoothie. Kies exact drie fruitsoorten.");
                    Console.Write("Fruitsoort 1: ");
					string Fruitsoort1 = Console.ReadLine();
					Console.Write("Fruitsoort 2: ");
					string Fruitsoort2 = Console.ReadLine();
					Console.Write("Fruitsoort 3: ");
					string Fruitsoort3 = Console.ReadLine();
					Console.Write("Wil je melk of yoghurt als basis (m/y): ");
					char welkewilje = Console.ReadKey().KeyChar;
					
					Console.WriteLine();
					Console.WriteLine($"Fruitsoorten: {Fruitsoort1} {Fruitsoort2} {Fruitsoort3}");
					Console.WriteLine($"Basis: {welkewilje}");
					Console.WriteLine("Prijs: €3,00");
 					
					
                    break;
                default:
					Console.WriteLine($" deze optie is geen geldige keuze");
					
                    break;
            }
        }
    }
}
