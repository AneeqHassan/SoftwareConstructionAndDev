// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

static void Split(string name, out string firstNames, out string lastNames)
{
    int i = name.LastIndexOf(' ');
    firstNames = name.Substring(0, i);
    lastNames = name.Substring (i + 1);
}

string a, b;
Split("John Q. Public", out a, out b);
Console.WriteLine($"First Name: {a}");
Console.WriteLine($"Last Name: {b}");


