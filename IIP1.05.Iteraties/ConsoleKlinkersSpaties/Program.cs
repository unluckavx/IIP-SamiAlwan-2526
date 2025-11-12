using System;

namespace ConsoleKlinkersSpaties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            int aantalKlinkers = 0;
            int aantalSpaties = 0;
            string geheimschrift = "";
            foreach (char letter in tekst)
            {
                char lower = Char.ToLower(letter);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                {
                    aantalKlinkers++;
                }
                if (letter == ' ')
                {
                    aantalSpaties++;
                } 
                if (Char.IsLetter(letter))
                {
                    char nieuweLetter = (char)(letter + 1);
                    if (letter == 'z') nieuweLetter = 'a';
                    if (letter == 'Z') nieuweLetter = 'A';
                    geheimschrift += nieuweLetter;
                }
                else
                {
                    geheimschrift += letter; 
                }
            }

            Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");
            Console.WriteLine($"in geheimschrift: {geheimschrift}");
        }
    }
         }
