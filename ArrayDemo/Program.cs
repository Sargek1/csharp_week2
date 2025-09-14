using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int Size = 10;
        int[] data = new int[Size];

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < Size; i++)
        {
            while (true)
            {
                Console.Write($"  Value #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out data[i])) break;
                Console.WriteLine("   Invalid, please enter an integer.");
            }
        }

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("  1) View first -> last");
            Console.WriteLine("  2) View last -> first");
            Console.WriteLine("  3) View a specific position (1-10)");
            Console.WriteLine("  4) Quit");
            Console.Write("Choose (1-4): ");

            string? choice = Console.ReadLine();
            if (choice == "4") break;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("First -> Last:");
                    for (int i = 0; i < Size; i++)
                        Console.Write($"{data[i]} ");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Last -> First:");
                    for (int i = Size - 1; i >= 0; i--)
                        Console.Write($"{data[i]} ");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Enter a position (1-10): ");
                    if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= Size)
                        Console.WriteLine($"Position {pos} value: {data[pos - 1]}");
                    else
                        Console.WriteLine("Invalid position.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1-4.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
