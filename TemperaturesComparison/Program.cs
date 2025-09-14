using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int N = 5;
        int[] temps = new int[N];

        Console.WriteLine("Enter 5 daily Fahrenheit temperatures (-30 to 130):");
        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write($"  Day {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int t) && t >= -30 && t <= 130)
                {
                    temps[i] = t;
                    break;
                }
                Console.WriteLine("   Invalid: must be an integer between -30 and 130.");
            }
        }

        bool nonDecreasing = true; // "Getting warmer" if no temperature is lower than any previous one
        bool strictlyDecreasing = true; // "Getting cooler" if each temp is lower than the previous one

        for (int i = 1; i < N; i++)
        {
            if (temps[i] < temps[i - 1]) nonDecreasing = false;
            if (temps[i] >= temps[i - 1]) strictlyDecreasing = false;
        }

        Console.WriteLine();
        if (nonDecreasing) Console.WriteLine("Getting warmer.");
        else if (strictlyDecreasing) Console.WriteLine("Getting cooler.");
        else Console.WriteLine("It's a mixed bag.");

        Console.WriteLine("\nTemperatures (in order entered):");
        for (int i = 0; i < N; i++)
            Console.Write($"{temps[i]} ");
        Console.WriteLine();

        double avg = temps.Average();
        Console.WriteLine($"Average: {avg:F2}");
    }
}
