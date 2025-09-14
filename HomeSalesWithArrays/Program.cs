using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] initials = { 'D', 'E', 'F' };
        decimal[] totals = new decimal[initials.Length];

        while (true)
        {
            Console.Write("Enter salesperson initial (D/E/F) or Z to finish: ");
            string? s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Error: please enter D, E, F, or Z.");
                continue;
            }

            char ch = char.ToUpperInvariant(s.Trim()[0]);
            if (ch == 'Z') break;

            int idx = Array.IndexOf(initials, ch);
            if (idx < 0)
            {
                Console.WriteLine("Error: invalid initial. Valid: D, E, F (Z to finish).");
                continue;
            }

            Console.Write("Enter sale amount: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount < 0m)
            {
                Console.WriteLine("Error: sale amount must be non-negative.");
                continue;
            }

            totals[idx] += amount;
        }

        Console.WriteLine();
        decimal grand = 0m;
        for (int i = 0; i < initials.Length; i++)
        {
            Console.WriteLine($"{initials[i]} total: {totals[i]:C}");
            grand += totals[i];
        }
        Console.WriteLine($"Grand total: {grand:C}");

        decimal max = totals.Max();
        var winners = initials
            .Where((c, i) => totals[i] == max)
            .Select(c => c.ToString())
            .ToArray();

        if (winners.Length > 1)
            Console.WriteLine("Top sellers (tie): " + string.Join(", ", winners));
        else
            Console.WriteLine("Top seller: " + winners[0]);
    }
}
