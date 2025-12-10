using System;
class Program
{ 
    private static bool IsKlinkers(char c)
    {
        c = Char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
    private static int AantalLettergrepen(string woord)
    {
        int aantalgeg = 0;
        bool vorigeKlinker = false;

        foreach (char c in woord.ToLower())
        {
            bool nuKlinker = IsKlinkers(c);

            if (nuKlinker && !vorigeKlinker)
            {
                aantalgeg++;
            }

            vorigeKlinker = nuKlinker;
        }

        return aantalgeg;
    }
    private static double Complexiteit(string woord)
    {
        int aantalLetters = woord.Length;
        int lettergrepen = AantalLettergrepen(woord);

        double complexiteit = aantalLetters / 3.0 + lettergrepen;

        if (woord.ToLower().Contains('q')) complexiteit += 1;
        if (woord.ToLower().Contains('x')) complexiteit += 1;
        if (woord.ToLower().Contains('y')) complexiteit += 1;

        return Math.Round(complexiteit, 1);
    }
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            string woord = Console.ReadLine();

            if (woord == "")
            {
                Console.WriteLine("Bedankt en tot ziens.");
                break;
            }

            int aantalLetters = woord.Length;
            int lettergrepen = AantalLettergrepen(woord);
            double complexiteit = Complexiteit(woord);

            Console.WriteLine($"aantal karakters: {aantalLetters}");
            Console.WriteLine($"aantal lettergrepen: {lettergrepen}");
            Console.WriteLine($"complexiteit: {complexiteit}");
            Console.WriteLine();
        }
    }
}

