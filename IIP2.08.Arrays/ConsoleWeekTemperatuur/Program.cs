using System;

class Program
{
    private const int AANTAL_DAGEN = 7;

    static void Main(string[] args)
    {
        double[] temperaturen = LeesTemperaturen(AANTAL_DAGEN);

        double gemiddelde = BerekenGemiddelde(temperaturen);
        double hoogste = ZoekHoogste(temperaturen);
        double laagste = ZoekLaagste(temperaturen);

        ToonResultaat(temperaturen, gemiddelde, hoogste, laagste);

        Console.ReadKey();
    }

    private static double LeesTemperatuur(int dag)
    {
        Console.Write($"Geef de temperatuur op voor dag {dag}: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    private static double[] LeesTemperaturen(int aantal)
    {
        double[] temperaturen = new double[aantal];

        for (int i = 0; i < aantal; i++)
        {
            temperaturen[i] = LeesTemperatuur(i + 1);
        }

        return temperaturen;
    }

    private static double BerekenGemiddelde(double[] waarden)
    {
        double som = 0;

        for (int i = 0; i < waarden.Length; i++)
        {
            som += waarden[i];
        }

        return som / waarden.Length;
    }

    private static double ZoekHoogste(double[] waarden)
    {
        double hoogste = waarden[0];

        for (int i = 1; i < waarden.Length; i++)
        {
            if (waarden[i] > hoogste)
            {
                hoogste = waarden[i];
            }
        }

        return hoogste;
    }

    private static double ZoekLaagste(double[] waarden)
    {
        double laagste = waarden[0];

        for (int i = 1; i < waarden.Length; i++)
        {
            if (waarden[i] < laagste)
            {
                laagste = waarden[i];
            }
        }

        return laagste;
    }
    private static void ToonResultaat(double[] temperaturen, double gemiddelde, double hoogste, double laagste)
    {
        Console.Write("Temperaturen deze week: ");

        foreach (double temp in temperaturen)
        {
            Console.Write($"{temp:F1}°C ");
        }

        string samenvatting = $@"

Gemiddelde temperatuur: {gemiddelde:F1}°C
Hoogste temperatuur: {hoogste:F1}°C
Laagste temperatuur: {laagste:F1}°C";

        Console.WriteLine(samenvatting);
    }
}