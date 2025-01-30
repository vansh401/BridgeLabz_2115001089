using System;

public class StudentVoteChecker 
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }

        return age >= 18; 
    }

    public static void Main(string[] args)
    {
        int[] studentAges = new int[10];

        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            studentAges[i] = int.Parse(Console.ReadLine());

            bool canVote = CanStudentVote(studentAges[i]);

            if (canVote)
            {
                Console.WriteLine("Student " + (i + 1) + " (age " + studentAges[i] + ") can vote.");
            }
            else if (studentAges[i] < 0)
            {
                Console.WriteLine("Invalid age entered for student " + (i + 1) + ". Age cannot be negative.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " (age " + studentAges[i] + ") cannot vote.");
            }
        }
    }
}
