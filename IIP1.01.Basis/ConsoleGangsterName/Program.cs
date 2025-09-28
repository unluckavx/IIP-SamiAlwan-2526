using System;
 
namespace ConsoleGangsterName
{
    internal class Program
    {
    static void Main(string[] args)
    {
        string name = "GANGSTA NAME BUILDER"; 

string header = $@"************************
| {name} |
************************";
Console.WriteLine(header);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
  Console.Write("Give the first name of any Disney character: "); 
  string naam = Console.ReadLine();
  Console.Write("Give any workbench tool: ");
  string tool = Console.ReadLine();
  Console.Write("What is your last name: ");
  string lastname = Console.ReadLine();
  string gangsterName = naam + " 'the " + tool + "' " + lastname;
  Console.Write($"Your Gangsta name: "); 
  Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"{naam} 'the {tool}' {lastname}");  
  Console.ResetColor();


    }
    }
}