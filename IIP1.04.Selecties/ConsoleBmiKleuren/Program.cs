using System;

namespace ConsoleBmiKleuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
			
            Console.WriteLine(@"BMI CALCULATOR
===============");

           Console.Write("Lengte (in cm): ");
           int Lengte = Convert.ToInt32(Console.ReadLine());


           Console.Write("Gewicht (in kg): ");
           int Gewicht = Convert.ToInt32(Console.ReadLine());

           double LengteToMeter = Convert.ToDouble(Lengte) / 100;
           double TotaalBmi = Convert.ToDouble(Gewicht) / Math.Pow(LengteToMeter, 2);

           Console.WriteLine($"Je BMI bedraagt: {TotaalBmi:F1}");
           Console.WriteLine();
			
           if (TotaalBmi < 18.5)
           {
				
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Je hebt ondergewicht");
           }
			
           else if (TotaalBmi >= 18.5 && TotaalBmi < 25)
           {
				
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Je gewicht is normaal");
           }
			
           else if (TotaalBmi >= 25 && TotaalBmi < 30)
           {
				
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Je hebt overgewicht");
           }
			
           else
           {
				
		   Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Je hebt obesitas");
           }
			
		   Console.ResetColor();
           Console.WriteLine();
			
		   }
  }
}
