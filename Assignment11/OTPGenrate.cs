using System;

class OTPGenrate
{
    static void Main()
    {
        int[] otps = new int[10];
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otps.Length; i++)
        {
            Console.WriteLine(otps[i]);
        }

        bool areUnique = AreOTPsUnique(otps);
        Console.WriteLine("Are all OTPs unique? " + areUnique);
    }

    static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
