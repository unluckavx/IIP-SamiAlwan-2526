using System;

namespace ConsoleSom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een getal in (q om te stoppen):");

            int som = 0;
            string input = Console.ReadLine();
            while (input != "q")
            {
                int getalnummer = Convert.ToInt32(input);
                som += getalnummer;
                Console.Write("Voer een getal in (q om te stoppen): ");
                input = Console.ReadLine();
            }

          
	 Console.WriteLine($"De som is: {som}");
        }
    }
}
