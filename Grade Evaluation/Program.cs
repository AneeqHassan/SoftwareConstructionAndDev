// See https://aka.ms/new-console-template for more information
Console.WriteLine("Grade Evaluation!");
Console.WriteLine("Enter your marks (0 - 100) :");
int marks = int.Parse(Console.ReadLine()!);
if (marks < 0 || marks > 100)
{
    Console.WriteLine("Invalid marks");
}
else if (marks >= 90)
{
    Console.WriteLine("Grade : A");
}
else if (marks >= 80)
{
    Console.WriteLine("Grade : B");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade : C");

}
else if (marks >= 60)
{
    Console.WriteLine("Grade : D");
}
else
{
    Console.WriteLine("Grade : F");
}
