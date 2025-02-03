using System;

class NumberGuess
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100. I will try to guess it!");

        int low = 1, high = 100, guess;
        Random random = new Random();

        while (true)
        {
            guess = random.Next(low, high + 1);
            Console.WriteLine("Is your number " + guess + "? (Type 'low', 'high', or 'correct')");
            string response = Console.ReadLine().ToLower();

            if (response == "correct")
            {
                Console.WriteLine("Great! I guessed your number.");
                break;
            }
            else if (response == "low")
            {
                low = guess + 1;
            }
            else if (response == "high")
            {
                high = guess - 1;
            }
        }
    }
}
