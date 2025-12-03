using System;

class Program
{
		private static void MaakTafels(int get, int len = 10)
    {
        Console.WriteLine($"{get}x{len} tafel:");

        for (int i = 1; i <= len; i++)
        {
        Console.WriteLine($"{get} x {i} = {get * i}");
        }

        Console.WriteLine();
    }
													
		private static int vraagpositiefgetal()		// vraag positie getal
    {
        Console.Write("Geef een positief getal: ");
        int getalNR = Convert.ToInt32(Console.ReadLine());

        while (getalNR <= 0)
        {
        Console.Write("Het getal moet positief zijn! Geef een getal: ");
        getalNR = Convert.ToInt32(Console.ReadLine());
        }

        return getalNR;
    }

		private static void Main(string[] args)
    {
        MaakTafels(4, 6);
        MaakTafels(2, 5);

        MaakTafels(7);
        
        int getalNR = vraagpositiefgetal();
        int lengte = vraagpositiefgetal();
        
        MaakTafels(getalNR, lengte);
        Console.ReadKey();
    }
}
