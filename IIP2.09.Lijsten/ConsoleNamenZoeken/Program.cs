using System;
class Program
{
    static void Main(string[] args)
    {
        string[] namen = {
            "Elias", "Fatima", "Noah", "Aisha", "Liam",
            "Sofia", "Kenji", "Mila", "Omar", "Yara"
        };

        char keuze;

        do
        {
            Console.Clear();
            ToonMenu();
            Console.Write("Maak een keuze: ");
            keuze = Convert.ToChar(Console.ReadLine().ToLower());

            switch (keuze)
            {
                case 'a':
                    ControleerNaamBestaat(namen);
                    break;

                case 'b':
                    ZoekVolgnummerNaam(namen);
                    break;

                case 'c':
                    ZoekNaamWoord(namen);
                    break;

                case 'd':
                    ZoekNaamOpLengte(namen);
                    break;
            }

            if (keuze != 'e')
            {
                Console.WriteLine("Druk op een toets om verder te gaan...");
                Console.ReadKey();
            }

        } while (keuze != 'e');
    }

    private static void ToonMenu()
    {
        Console.WriteLine("""
--- MENU ---
a. Controleer of naam bestaat
b. Zoek volgnummer van naam
c. Zoek naam op woord
d. Zoek naam op lengte
e. Afsluiten
""");
    }

    private static bool NaamBestaatWel(string[] namen, string naam)
    {
        foreach (string n in namen)
        {
            if (n.Equals(naam, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    private static void ControleerNaamBestaat(string[] namen)
    {
        Console.Write("Naam: ");
        string naam = Console.ReadLine();

        if (NaamBestaatWel(namen, naam))
            Console.WriteLine($"'{naam}' komt voor in de lijst");
        else
            Console.WriteLine($"'{naam}' komt niet voor in de lijst");
    }

    private static int ZoekVolgnummer(string[] namen, string naam)
    {
        for (int i = 0; i < namen.Length; i++)
        {
            if (namen[i].Equals(naam, StringComparison.OrdinalIgnoreCase))
                return i + 1; 
        }
        return 0;
    }

    private static void ZoekVolgnummerNaam(string[] namen)
    {
        Console.Write("Naam: ");
        string naam = Console.ReadLine();

        int positie = ZoekVolgnummer(namen, naam);

        if (positie == 0)
            Console.WriteLine($"'{naam}' is niet gevonden");
        else
            Console.WriteLine($"'{naam}' is gevonden op positie {positie}");
    }

    private static string ZoekWoord(string[] namen, string woord)
    {
        foreach (string naam in namen)
        {
            if (naam.ToLower().Contains(woord.ToLower()))
                return naam;
        }
        return null;
    }

    private static void ZoekNaamWoord(string[] namen)
    {
        Console.Write("Zoekwoord: ");
        string woord = Console.ReadLine();

        string resultaat = ZoekWoord(namen, woord);

        if (resultaat == null)
            Console.WriteLine($"geen naam gevonden voor '{woord}'");
        else
            Console.WriteLine($"'{resultaat}' gevonden voor '{woord}'");
    }

    private static string ZoekOpLengte(string[] namen, int lengte)
    {
        foreach (string naam in namen)
        {
            if (naam.Length == lengte)
                return naam;
        }
        return null;
    }

    private static void ZoekNaamOpLengte(string[] namen)
    {
        Console.Write("Lengte: ");
        int lengte = Convert.ToInt32(Console.ReadLine());

        string resultaat = ZoekOpLengte(namen, lengte);

        if (resultaat == null)
            Console.WriteLine($"geen naam gevonden met {lengte}");
        else
            Console.WriteLine($"naam met {lengte}: {resultaat}");
    }
}