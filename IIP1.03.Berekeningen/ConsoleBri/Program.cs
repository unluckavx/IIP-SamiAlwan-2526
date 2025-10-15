using System;

namespace ConsoleBri
{
    internal class Program
    {
        static void Main(string[] args)
        {
		
			string header = @"BRI CALCULATOR 🏋️
=================";
           
		    Console.WriteLine(header);
            
			const double basis = 364.2;
            const double factor = 365.5;
			const double ondergrens = 3.41;
			const double bovengrens = 4.44;

            Console.Write("Taille (in cm): ");
            int taille = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lengte (in cm): ");
            int lengte = Convert.ToInt32(Console.ReadLine());
			
			double BRI = basis - factor * Math.Sqrt(Math.Max(0.0, 1.0 - Math.Pow(((double)taille) / (Math.PI * (double)lengte), 2.0)));
            
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"JE BRI bedraagt: {BRI:F1}");
            Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"\nEen BRI tussen {ondergrens} en {bovengrens} is normaal.");
			Console.ResetColor();
        }
    }
}