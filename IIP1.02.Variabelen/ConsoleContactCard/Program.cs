using System;

namespace ConsoleContactCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Naam = "Bobby Peru";
            bool Gehuwd = false;
            string Telefoon = "0486/33.22.19";
            int Leeftijd = 25;
			decimal Salaris = 2500.00m;
            string Geslacht = "m";
			double Lengte = 1.75;

            Console.WriteLine($@"
-------------------------
*
* Naam: {Naam}
* Gehuwd: {(Gehuwd ? "ja" : "nee")}
* Telefoon: {Telefoon}
* Leeftijd: {Leeftijd} jaar
* Salaris: {Salaris:C}  per maand
* Geslacht: {Geslacht}
* Lengte: {Lengte:F2}m
*
-------------------------");


            Console.WriteLine("druk op een toets om verder te gaan...");
			
			
        }
    }
}