using System;

namespace ConsoleAbonnement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
		Console.WriteLine("Bestelgegevens");
        Console.WriteLine("==============");
		
        Console.Write("- naam klant: ");
        string klant = Console.ReadLine();
		
        Console.Write("- aantal toegangsbeurten: ");
        string aantal = Console.ReadLine();
		
        Console.Write("- prijs (b.v. 122,5): ");
        string prijs = Console.ReadLine();

		Console.Write("- incl. badkledij (true of false): ");
	    string badkledij = Console.ReadLine();
		
		Console.Write("- geslacht (druk 'm' of 'v'): ");
		char geslacht = Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine();
        Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.DarkYellow; 
Console.WriteLine(@$"
Samenvatting
============
- houder: {klant}
- geslacht: {geslacht}
- prijs: {prijs}
- aantal beurten: {aantal}
- incl. badkledij: {badkledij}
- kaartnummer: XXX-XXXX-XX  ");
Console.WriteLine();
Console.ResetColor();
Console.Write("druk op een toets om verder te gaan...");


		
		}
	}
}