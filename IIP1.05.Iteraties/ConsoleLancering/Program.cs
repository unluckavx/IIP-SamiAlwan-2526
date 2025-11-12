using System;

class Program
{
    
	
	
	
	private static void TelAfFor(int seconden)
    {
        Console.WriteLine("for-versie:");
        for (int i = seconden; i >= 1; i--)
        {
           Console.WriteLine($"{i}...");
        }
        Console.WriteLine("Lift off!");
        Console.WriteLine();
    }
	
	
	
	
	
    private static void TelAfDoWhile(int seconden)
    {
        Console.WriteLine("do-while versie:");
        int i = seconden;
        do
        {
            Console.WriteLine($"{i}...");
            i--;
        } while (i >= 1);
        Console.WriteLine("Lift off!");
        Console.WriteLine();
    }
	
	
	
	
	
	
    private static void TelAfWhile(int seconden)
    {
        Console.WriteLine("while versie:");
        int i = seconden;
        while (i >= 1)
        {
            Console.WriteLine($"{i}...");
            i--;
        }
        Console.WriteLine("Lift off!");
        Console.WriteLine();
    }
	
    private static void Main(string[] args)
    {
        Console.Write("Hoeveel seconden tot lancering? ");
        int seconden = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        TelAfFor(seconden);
        TelAfDoWhile(seconden);
        TelAfWhile(seconden);
		
		Console.ReadKey();
    }
}
