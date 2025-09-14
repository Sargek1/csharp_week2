using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter a four-digit account number: ");
        string? s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s) || s.Length != 4 || !s.All(char.IsDigit))
        {
            Console.WriteLine("Invalid input: must be exactly four digits (e.g., 7770).");
            return;
        }

        int firstThree = int.Parse(s.Substring(0, 3));
        int fourth = s[3] - '0';

        bool isValid = (firstThree % 7) == fourth;
        Console.WriteLine(isValid ? "Valid account number." : "Invalid account number.");
    }
}
