using System;

class VotingEligibility
{
    static void Main()
    {
        int[] ages = new int[10];
        
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter the age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine("Invalid age entered for student " + (i + 1));
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("The student with the age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
            }
        }
    }
}
