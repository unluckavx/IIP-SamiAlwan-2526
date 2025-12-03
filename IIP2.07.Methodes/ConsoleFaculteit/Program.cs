using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FACULTEIT BEREKENEN");
        Console.Write("Geef een geheel getal: ");

        int getal1 = Convert.ToInt32(Console.ReadLine());
        int resultaat = Faculteit(getal1);
		
		Console.WriteLine(@$"De faculteit is {resultaat}");
		Console.ReadLine();
    }

		private static int Faculteit(int n)
    {
        int product = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }

        return product;
    }
}
