using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter marks for Physics: ");
        double physics = double.Parse(Console.ReadLine());

        Console.Write("Enter marks for Chemistry: ");
        double chemistry = double.Parse(Console.ReadLine());

        Console.Write("Enter marks for Maths: ");
        double maths = double.Parse(Console.ReadLine());

        double totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300) * 100;

        Console.WriteLine("Total Marks: " + totalMarks + "/300");
        Console.WriteLine("Percentage: " + percentage + "%");

        string grade = "";
        string remarks = "";

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below, but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}
