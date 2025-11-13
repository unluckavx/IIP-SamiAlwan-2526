using System;

namespace ConsoleSnoepmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal PRIJS_DRANK = 2.00m;
            const decimal PRIJS_SNOEP = 1.50m;
            decimal saldo = 0m;
            string keuze = "";
            {
                Console.Clear();
                Console.WriteLine("SNOEPMACHINE 🍬🥤");
                Console.WriteLine("-----------------");
                Console.WriteLine("a. geld inwerpen");
                Console.WriteLine($"b. drank kopen ({PRIJS_DRANK:0.00} euro)");
                Console.WriteLine($"c. snoep kopen ({PRIJS_SNOEP:0.00} euro)");
                Console.WriteLine("d. stoppen");
                Console.WriteLine();
                Console.WriteLine($"Huidig saldo: {saldo:0.00} euro");
                Console.Write("Maak je keuze: ");
                keuze = Console.ReadLine().ToLower();
					
					switch (keuze)
                {
					case "a":
					Console.Write("Voer een bedrag in: ");
					if (decimal.TryParse(Console.ReadLine(), out decimal inworp))
                {
					if (inworp % 0.5m == 0)
                {
                    saldo += inworp;
                    Console.WriteLine($"Je hebt {inworp:0.00} euro toegevoegd.");
                }
                    else	
                {
					Console.WriteLine("Fout: bedrag moet een veelvoud van 0,5 euro zijn!");
                }
                }
					else
                {
					Console.WriteLine("Ongeldige invoer. Typ een getal.");
                }
					break;
                    case "b":
                    if (saldo >= PRIJS_DRANK)
                {
                    saldo -= PRIJS_DRANK;
                    Console.WriteLine("Je hebt een drank gekocht. 🍹");
                }
                    else
                {
                    Console.WriteLine("Onvoldoende saldo voor drank!");
                }
                    break;
                    case "c":
                    if (saldo >= PRIJS_SNOEP)
                {
                    saldo -= PRIJS_SNOEP;
                    Console.WriteLine("Je hebt een snoep gekocht. 🍭");
                }
                    else
                {
                    Console.WriteLine("Onvoldoende saldo voor snoep!");
                }
                    break;
                    case "d":
                    Console.WriteLine("Bedankt voor je aankoop! 👋");
                    break;
                    default:
                    Console.WriteLine($"'{keuze}' is geen geldige keuze, druk op een toets om verder te gaan...");
                    break;
                }
                    Console.WriteLine("Druk op een toets om verder te gaan...");
                    Console.ReadKey();
            }       while (keuze != "d");
        }
    }
}