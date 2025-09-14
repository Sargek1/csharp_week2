using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter business name: ");
        string? name = Console.ReadLine() ?? "";

        string noSpaces = string.Concat(name.Where(c => !char.IsWhiteSpace(c)));
        string suggestion = $"www.{noSpaces}.com";

        Console.WriteLine($"Suggested web address: {suggestion}");
    }
}
