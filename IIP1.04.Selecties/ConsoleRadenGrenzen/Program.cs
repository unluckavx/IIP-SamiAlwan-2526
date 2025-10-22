using System;

namespace ConsoleRadenGrenzen
{
    internal class Program
    {
      const int MaxAantalPogingen = 1;

        static void Main(string[] args)
        {
            Console.WriteLine(@"
 ____  ____  ____  _____ _     
/  __\/  _ \/  _ \/  __// \  /|
|  \/|| / \|| | \||  \  | |\ ||
|    /| |-||| |_/||  /_ | | \||
\_/\_\\_/ \|\____/\____\\_/  \|");

            Console.WriteLine();
			
            Console.WriteLine("Geef twee gehele getallen.");
            Console.Write("- getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("- getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            if (getal1 > getal2)
				
            {
                int tijdelijk = getal1;
                getal1 = getal2;
                getal2 = tijdelijk;
            }
            Random random = new Random();
            int geheimGetal = random.Next(getal1, getal2 + 1);
            Console.WriteLine($"Even denken... ja, ik heb een getal tussen {getal1} en {getal2} in mijn hoofd.");
            Console.Write("Doe een gok: ");
            int gok = Convert.ToInt32(Console.ReadLine());
            if (gok == geheimGetal)
				
			
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JUIST");
            }
            else
            {
				
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT");
				Console.ResetColor();

                int verschil = Math.Abs(geheimGetal - gok);
                if (verschil <= 2)
                {Console.WriteLine("Je zat er nochtans niet ver af!");
                }
				
            }
        }
    }
}