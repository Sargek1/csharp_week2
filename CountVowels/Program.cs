using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a phrase: ");
        string? s = Console.ReadLine() ?? "";

        string vowels = "aeiouAEIOU";
        int count = s.Count(ch => vowels.IndexOf(ch) >= 0);

        Console.WriteLine($"Vowel count: {count}");
    }
}
