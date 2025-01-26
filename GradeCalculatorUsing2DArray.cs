using System;

class GradeCalculatorUsing2DArray
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        double[,] marks = new double[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            double physics, chemistry, maths;

            do
            {
                Console.WriteLine("Enter Physics marks for student " + (i + 1) + ": ");
                physics = double.Parse(Console.ReadLine());
                if (physics < 0)
                {
                    Console.WriteLine("Invalid input. Marks cannot be negative. Please enter again.");
                }
            } while (physics < 0);

            do
            {
                Console.WriteLine("Enter Chemistry marks for student " + (i + 1) + ": ");
                chemistry = double.Parse(Console.ReadLine());
                if (chemistry < 0)
                {
                    Console.WriteLine("Invalid input. Marks cannot be negative. Please enter again.");
                }
            } while (chemistry < 0);

            do
            {
                Console.WriteLine("Enter Maths marks for student " + (i + 1) + ": ");
                maths = double.Parse(Console.ReadLine());
                if (maths < 0)
                {
                    Console.WriteLine("Invalid input. Marks cannot be negative. Please enter again.");
                }
            } while (maths < 0);

            marks[i, 0] = physics;
            marks[i, 1] = chemistry;
            marks[i, 2] = maths;

            double totalMarks = physics + chemistry + maths;
            percentages[i] = (totalMarks / 300) * 100;

            if (percentages[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = "D";
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = "E";
            }
            else
            {
                grades[i] = "R";
            }
        }

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": ");
            Console.WriteLine("Physics Marks: " + marks[i, 0]);
            Console.WriteLine("Chemistry Marks: " + marks[i, 1]);
            Console.WriteLine("Maths Marks: " + marks[i, 2]);
            Console.WriteLine("Percentage: " + percentages[i] + "%");
            Console.WriteLine("Grade: " + grades[i]);
            Console.WriteLine();
        }
    }
}
