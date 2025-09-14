using System;
class Program
{
static void Main()
{
Console.Write("Enter birth month (1-12):");
if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
{
Console.WriteLine($"{month} is a valid month.");
}
else
{
Console.WriteLine("Error: month must be between 1 and 12.");
}
}
}
