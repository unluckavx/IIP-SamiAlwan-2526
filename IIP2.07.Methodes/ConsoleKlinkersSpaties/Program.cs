using System;
class Program
{
    
		private static int AantalSpaties(string tekst)
    {
        int aantalgeg = 0;
        foreach (char c in tekst)
        {
            if (c == ' ') aantalgeg++;
        }
        return aantalgeg;
    }
		private static int AantalKlinkers(string tekst)
    {
        int aantalgeg = 0;

        foreach (char c in tekst)
        {
		char x = Char.ToLower(c);

            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                aantalgeg++;
            }
        }
        return aantalgeg;
    }
		private static string NaarGeheimschrift(string tekst)
    {
        string antwoord = "";

        foreach (char c in tekst)
        {
            if (c == ' ')
            {
                antwoord += ' ';
            }
            else
            {
                int code = (int)c;   
                code++;              
                antwoord += (char)code; 
            }
        }
		return antwoord;
    }
		static void Main(string[] args)
    {
        Console.Write("Geef een tekst: ");
        string tekst = Console.ReadLine();

        int Klinkers = AantalKlinkers(tekst);
        int Spaties = AantalSpaties(tekst);
        string GeheimSchrift = NaarGeheimschrift(tekst);
		
        Console.WriteLine($"deze tekst bevat {Klinkers} Klinkers en {Spaties} spaties");
        Console.WriteLine($"in geheimschrift: {GeheimSchrift}");
}
}