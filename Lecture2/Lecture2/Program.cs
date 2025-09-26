// See https://aka.ms/new-console-template for more information
string s1 = Console.ReadLine();
string substring1 = s1.Substring(0, 10);
string substring2 = s1.Substring(1, 10);
Console.WriteLine($"The first 10 characters are :{substring1}");
Console.WriteLine($"The first 10 characters are :{substring2}");

char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
foreach (char c in vowel)
{
    if(s1.IndexOf(c) == -1)
        continue;
    if(s1.LastIndexOf(c) == -1)
        continue;
    Console.WriteLine($"First Index of {vowel} is s1 = {s1.IndexOf(c)}");
    Console.WriteLine($"Last Index of {vowel} is s1 = {s1.LastIndexOf(c)}");
}

Console.WriteLine($"S1 in Lowercase : {s1.ToLower()}");
Console.WriteLine($"S1 in Uppercase : {s1.ToUpper()}");

char[] splitChar = new char[] { ' ', ',' };
string[] spString = s1.Split(splitChar);

foreach (string s in spString)
{ 
     Console.WriteLine(s); 

}   