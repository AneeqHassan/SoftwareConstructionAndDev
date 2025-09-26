// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//1.
//int[][] jagged = new int[2][];
//jagged[0] = new int[] { 1, 2, 3};
//jagged[1] = new int[] { 4, 5 } ;

//foreach (int[] row in jagged)
//{

//        foreach(var val in row)
//        {
//            Console.Write(val + " ");
//        }
//        Console.WriteLine();

//    }

//2.

//Console.WriteLine("Enter the number of rows:");
//int rows = int.Parse(Console.ReadLine());
//int[][] jagged = new int[rows][];

//for (int i = 0; i < rows; i++)
//{

//    Console.Write($"Enter number of elements in row {i + 1}: ");
//    int size = int.Parse(Console.ReadLine());
//    jagged[i] = new int[size];

//    for (int j = 0; j < size; j++)
//    {
//        Console.Write($"Enter value of row {i + 1}, col {j + 1}: ");
//        jagged[i][j] = int.Parse(Console.ReadLine());
//    }
//    Console.WriteLine("Jagged Array: ");
//    foreach (var row in jagged)
//    {
//        Console.WriteLine(string.Join(" ", rows));
//    }
//}

//3.
//int[][] jagged =
//{
//    new int[] {1, 2, 3},
//    new int[] {4,5},
//    new int[] {6, }
//};

//for (int i = 0; i < jagged.Length; i++)
//{
//    int sum = 0;
//    for (int j = 0; j < jagged[i].Length; j++)
//    {
//        sum += jagged[i][j];
//    }
//    Console.WriteLine($"Sum of row {i + 1}: {sum}");
//}

//4. 
//int[][] jagged =
//{
//    new int[] {1, 2, 3},
//    new int[] {4,5},
//    new int[] {6, }
//};

//for (int i = 0; i < jagged.Length; i++)
//{
//    Array.Reverse(jagged[i]);
//}
//foreach (var row in jagged)
//{
//    Console.WriteLine(string.Join(" ", row));
//}
//5.

//string text = "Programming";
//Console.WriteLine(text.Substring(0,4);
//Console.WriteLine(text.IndexOf('gr'));

//6.
//string text = "Hello, World!";
//string result = text.Replace("World", "C#");
//Console.WriteLine(result);



