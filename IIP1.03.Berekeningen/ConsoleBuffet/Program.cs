using System;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prijzen
            const double PRIJS_SEIZOENSBUFFET = 18.5;
            const double PRIJS_DESSERTBUFFET = 7.95;
            const double PRIJS_KIDSMENU = 8.95;

           
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("WELKOM IN HET BUFFETRESTAURANT");
            Console.WriteLine("==============================\n");
            Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen!");
            Console.WriteLine("!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!\n");
            Console.ResetColor();

            //Invoer van aantallen
            Console.Write($"Aantal seizoensbuffets (€{PRIJS_SEIZOENSBUFFET}): ");
            int aantalSeizoens = int.Parse(Console.ReadLine());

            Console.Write($"Aantal dessertbuffets (€{PRIJS_DESSERTBUFFET}): ");
            int aantalDessert = int.Parse(Console.ReadLine());

            Console.Write($"Aantal kids menus (€{PRIJS_KIDSMENU}): ");
            int aantalKids = int.Parse(Console.ReadLine());

            //Fooi
            Console.Write("\nFooi (0 indien geen): ");
            double fooi = double.Parse(Console.ReadLine());

            //Berekening totaalbedrag
            double totaal = (aantalSeizoens * PRIJS_SEIZOENSBUFFET)
                          + (aantalDessert * PRIJS_DESSERTBUFFET)
                          + (aantalKids * PRIJS_KIDSMENU)
                          + fooi;

            Console.WriteLine($"Totaal te betalen: €{totaal:F2}");

            //Afronden naar beneden
            double afgerondnaarbeneden = Math.Floor(totaal);
            Console.WriteLine($"Afgerond naar beneden: €{afgerondnaarbeneden:F0}");

            //Cash en wisselgeld
            Console.Write("\nCash betaald: ");
            double cash = double.Parse(Console.ReadLine());

            double wisselgeld = cash - afgerondnaarbeneden;
            Console.WriteLine("\nU krijgt terug:");

            int rest = (int)Math.Round(wisselgeld);
            int b50 = rest / 50; rest %= 50;
            int b20 = rest / 20; rest %= 20;
            int b10 = rest / 10; rest %= 10;
            int b5  = rest / 5;  rest %= 5;
            int m2  = rest / 2;  rest %= 2;
            int m1  = rest;

            
            Console.WriteLine($"- {b50} briefje(s) van 50");
            Console.WriteLine($"- {b20} briefje(s) van 20");
            Console.WriteLine($"- {b10} briefje(s) van 10");
            Console.WriteLine($"- {b5} briefje(s) van 5");
            Console.WriteLine($"- {m2} stuk(ken) van 2");
            Console.WriteLine($"- {m1} stuk(ken) van 1");
            Console.ResetColor();
        }
    }
}