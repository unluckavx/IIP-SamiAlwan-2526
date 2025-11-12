using System;

class Program
{
    static void Main()
    {
        double saldo = 1000.0;
        bool stoppen = false;

        Console.WriteLine("Bankautomaat");
        Console.WriteLine("============");
        while (!stoppen)
        {
            Console.WriteLine($"huidig saldo: {saldo:C}");
            Console.WriteLine();
            Console.WriteLine("a. afhaling");
            Console.WriteLine("b. storting");
            Console.WriteLine("c. stoppen");
            Console.Write("je keuze: ");
            string keuze = Console.ReadLine().ToLower();

            switch (keuze)
            {
          case "a":
                    Console.Write("welk bedrag wil je afhalen: ");
                    double afhaling = Convert.ToDouble(Console.ReadLine());
                    if (afhaling % 20 != 0 && afhaling % 50 != 0)
                {
                        Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
                }
                    else if (afhaling > saldo)
                {
                        Console.WriteLine("fout: onvoldoende saldo");
                }
                    else
                {
                        saldo -= afhaling;
                        Console.WriteLine($"afhaling ok - het nieuw saldo is {saldo:C}");
                }
                    break;

         case "b":
                    Console.Write("welk bedrag wil je storten: ");
                    double storting = Convert.ToDouble(Console.ReadLine());
                    saldo += storting;
                    Console.WriteLine($"storting ok - het nieuw saldo is {saldo:C}");
                    break;

         case "c":
                    Console.WriteLine("bedankt en tot ziens");
                    stoppen = true;
                    break;

         default:
                    Console.WriteLine("ongeldige keuze");
                    break;
            }
        }
    }
}
