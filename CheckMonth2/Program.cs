class Program
{
Console.Write("Enter Birth Month (1-12): ");
if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
{
Console.WriteLine("Error: month must be between 1 and 12.");
return;
}
Console.Write("Enter birth day: ");
if (!int.TryParse(Console.ReadLine(), out int day))
{
Console.WriteLine("Error: day must be a number.");
return;
}
int maxDays = month switch
{
2 => 29,                    // per assignment rule
4 or 6 or 9 or 11 => 30,    // Apr, Jun, Sep, Nov
_ => 31
};

if (day >= 1 && day <= maxDays)
{
Console.WriteLine($"{month}/{day} is a valid date.");
}
else
{
Console.WriteLine($"Error: day must be between 1 and {maxDays} for month {month}.");
}
}
}
