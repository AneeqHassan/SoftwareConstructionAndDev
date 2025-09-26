// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        double[][] studentArray = new double[numStudents][];
        int[] numCourses = new int[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter the number of courses for student {i + 1}: ");
            numCourses[i] = int.Parse(Console.ReadLine());
            studentArray[i] = new double[numCourses[i]];

            for (int j = 0; j < numCourses[i]; j++)
            {
                Console.Write($"Enter the grade for course {j + 1} of student {i + 1}: ");
                studentArray[i][j] = double.Parse(Console.ReadLine());

            }

        }
        stuAvg(studentArray, numStudents, numCourses);

    }
    static void stuAvg(double[][] studentArray, int numStudents, int[] numCourses)
    {
        for (int i = 0; i < numStudents; i++)
        {
            double sum = 0;
            for (int j = 0; j < numCourses[i]; j++)
            {
                sum += studentArray[i][j];
            }
            double average = sum / numCourses[i];
            Console.WriteLine($"Student {i + 1}: Sum = {sum}, Average = {average:F2}");
        }
    }
}
