using System;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
		
			Console.WriteLine(@"BMI CALCULATOR ️
================");
            
			Console.Write("Lengte (in cm): ");
			int Lengte = Convert.ToInt32(Console.ReadLine());
			
			
			Console.Write("Gewicht (in kg): ");
			int gewicht = Convert.ToInt32(Console.ReadLine());	
			
			
			double LengteNaarMeter = Convert.ToDouble(Lengte) / 100;
			double BMI = Convert.ToDouble(gewicht) / Math.Pow(LengteNaarMeter, 2);
			Console.WriteLine($"Je BMI bedraagt: {BMI:F1}");
		
			
			
			
			
			
			
		
			
        }
    }
}