// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Write a number : ");
int number = int.Parse(Console.ReadLine()!);
if (number <= 0)
    Console.WriteLine("Invalid number!");
else
{
    int count2 = 0;
    int count5 = 0;
    while (number > 0)
    {
        if (number % 2 == 0)
        {
            count2++;
        }
        if (number % 5 == 0)
        {
            count5++;
        }
        Console.WriteLine("Write a number again: ");
        number = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"Number divisible by 2: {count2}");
    Console.WriteLine($"Number divisible by 5: {count5}");
}

