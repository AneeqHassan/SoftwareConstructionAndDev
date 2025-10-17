// See https://aka.ms/new-console-template for more information
string[] names = { "Tom", "Harry", "Mary", "Jay" };

var query = 
    names.Where(n => n.Contains("a")).
    OrderBy(n => n.Length).
    Select (n => n.ToUpper());

foreach(string name in query)
{
    Console.WriteLine(name);
}
