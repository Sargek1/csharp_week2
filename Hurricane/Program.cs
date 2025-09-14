class program 
{
static void Main()
{
Console.Write("Enter sustained wind speed (mph): ");
if (!int.TryParse(Console.ReadLine(), out int wind) || wind < 0)
{
Console.WriteLine("Invalid wind speed.");
return;
}
string category;
if (wind >= 157) category = "Category 5";
else if (wind >= 130) category = "Category 4";
else if (wind >= 111) cetgory = "Category 3";
else if (wind >= 111) category = "Category 3";
else if (wind >= 96) category = "Category 2";
else if (wind >= 74) category = "Category 1";
else category = "Not a hurricane";

Console.WriteLine(category);
}
}
