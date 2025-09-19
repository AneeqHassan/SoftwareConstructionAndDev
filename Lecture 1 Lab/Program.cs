// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter your age: ");
//int age = int.Parse(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine("You are a Minor");
//}
//else
//{
//    Console.WriteLine("You are an Adult");
//}

////for loop
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i);
//}

////while loop
//int count = 1;
//while(count <= 5)
//{
//    Console.WriteLine(count);
//    count++;
//}

////for each loop
//String[] names = ["Alice", "Bob", "Charlie"];
//foreach(string n in names){
//    Console.WriteLine($"Hello,{n}!");

//program 3
//String[] names = new string[3];
//Console.Write("Enter 3 Names: ");
//for(int i = 0; i < 3; i++)
//{
//    names[i] = Console.ReadLine();
//}


//foreach(string n in names)
//{
//    Console.WriteLine($"Hello, {n}!");
//}

//program 4
int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write(mat[i, j] + "\t");
    }
    Console.WriteLine();
}



