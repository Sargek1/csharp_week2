using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        decimal danielle = 0m, edward = 0m, fatima = 0m;

        while (true)
        {
            Console.Write("Enter salesperson initial (D/E/F) or Z to finish: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: please enter D, E, F, or Z.");
                continue;
            }

            char init = char.ToUpperInvariant(input.Trim()[0]);

            if (init == 'Z')
                break;

            if (init != 'D' && init != 'E' && init != 'F')
            {
                Console.WriteLine("Error: invalid initial. Use D, E, or F (Z to finish).");
                continue;
            }

            Console.Write("Enter sale amount: ");
            string? amtStr = Console.ReadLine();
            if (!decimal.TryParse(amtStr, out decimal amount) || amount < 0m)
            {
                Console.WriteLine("Error: sale amount must be a non-negative number.");
                continue;
            }

            switch (init)
            {
                case 'D': danielle += amount; break;
                case 'E': edward += amount; break;
                case 'F': fatima += amount; break;
            }
        }

        decimal grand = danielle + edward + fatima;

        Console.WriteLine();
        Console.WriteLine($"Danielle total: {danielle:C}");
        Console.WriteLine($"Edward total:   {edward:C}");
        Console.WriteLine($"Fatima total:   {fatima:C}");
        Console.WriteLine($"Grand total:    {grand:C}");

        // Determine top seller(s)
        decimal max = new[] { danielle, edward, fatima }.Max();
        var winners = new List<string>();
        if (danielle == max) winners.Add("Danielle");
        if (edward == max)   winners.Add("Edward");
        if (fatima == max)   winners.Add("Fatima");

        Console.WriteLine("Top seller: " + string.Join(", ", winners));
    }
}
