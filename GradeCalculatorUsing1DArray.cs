using System;

class GradeCalculatorUsing1DArray
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        double[] physicsMarks = new double[numberOfStudents];
        double[] chemistryMarks = new double[numberOfStudents];
        double[] mathsMarks = new double[numberOfStudents];
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
            physicsMarks[i] = physics;

            do
            {
                Console.WriteLine("Enter Chemistry marks for student " + (i + 1) + ": ");
                chemistry = double.Parse(Console.ReadLine());
                if (chemistry < 0)
                {
                    Console.WriteLine("Invalid input. Marks cannot be negative. Please enter again.");
                }
            } while (chemistry < 0);
            chemistryMarks[i] = chemistry;

            do
            {
                Console.WriteLine("Enter Maths marks for student " + (i + 1) + ": ");
                maths = double.Parse(Console.ReadLine());
                if (maths < 0)
                {
                    Console.WriteLine("Invalid input. Marks cannot be negative. Please enter again.");
                }
            } while (maths < 0);
            mathsMarks[i] = maths;

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
            Console.WriteLine("Student " + (i + 1) + ": Physics = " + physicsMarks[i] + ", Chemistry = " + chemistryMarks[i] + ", Maths = " + mathsMarks[i] + ", Percentage = " + percentages[i] + "%, Grade = " + grades[i]);
        }
    }
}
