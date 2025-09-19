// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your First name: ");
String name = Console.ReadLine();
Console.WriteLine("Enter your Last Name: ");
String lastName = Console.ReadLine();
Console.WriteLine($"Hello, {name} { lastName}!");
Console.WriteLine(String.Format("Hello, {0} {1}!", name, lastName));  