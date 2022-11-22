// See https://aka.ms/new-console-template for more information

Console.WriteLine("Leap year CLI.");

var year = int.Parse(Environment.GetCommandLineArgs()[1]);

if (year % 400 == 0)
{
    Console.WriteLine($"{year} is leap year.");
    return;
}

if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine($"{year} is leap year.");
    return;
}

Console.WriteLine($"{year} is not a leap year.");
Console.WriteLine();