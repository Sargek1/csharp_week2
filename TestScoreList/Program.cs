using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int N = 8;
        int[] scores = new int[N];

        Console.WriteLine("Enter 8 test scores (ints):");
        for (int i = 0; i < N; i++)
        {
            while (true)
            {
                Console.Write($"  Score #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out scores[i])) break;
                Console.WriteLine("   Invalid, please enter an integer.");
            }
        }

        double avg = scores.Average();

        Console.WriteLine($"\nAverage: {avg:F2}\n");
        for (int i = 0; i < N; i++)
        {
            double diff = scores[i] - avg; // positive = above average
            string direction = diff > 0 ? "above" : diff < 0 ? "below" : "at";
            Console.WriteLine($"Score #{i + 1}: {scores[i]} ({Math.Abs(diff):F2} {direction} average)");
        }
    }
}
