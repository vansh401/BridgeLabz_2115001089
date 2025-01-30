using System;

public static class NumberChecker 
{
    public static int CountDigits(int number) 
    { 
        return number.ToString().Length; 
    } 

    public static int[] GetDigitsArray(int number) 
    { 
        string numberStr = number.ToString(); 
        int[] digits = new int[numberStr.Length]; 
        for (int i = 0; i < numberStr.Length; i++) 
        { 
            digits[i] = int.Parse(numberStr[i].ToString()); 
        } 
        return digits; 
    } 

    public static int SumOfDigits(int[] digits) 
    { 
        int sum = 0; 
        foreach (int digit in digits) 
        { 
            sum += digit; 
        } 
        return sum; 
    }

    public static int SumOfSquaresOfDigits(int[] digits) 
    { 
        int sumOfSquares = 0; 
        foreach (int digit in digits) 
        { 
            sumOfSquares += (int)Math.Pow(digit, 2); 
        } 
        return sumOfSquares; 
    }

    public static bool IsHarshadNumber(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        int sumOfDigits = SumOfDigits(digits); 
        return number % sumOfDigits == 0; 
    } 

    public static int[,] FindDigitFrequency(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        int[,] frequency = new int[10, 2]; 
        for (int i = 0; i < 10; i++) 
        { 
            frequency[i, 0] = i; 
            frequency[i, 1] = 0; 
        } 
        foreach (int digit in digits) 
        { 
            frequency[digit, 1]++; 
        }
        return frequency; 
    }
}

class Program 
{
    static void Main() 
    { 
        int number = 1729; 

        int digitCount = NumberChecker.CountDigits(number); 
        Console.WriteLine("Count of digits: " + digitCount); 

        int[] digits = NumberChecker.GetDigitsArray(number); 
        Console.WriteLine("Digits array: " + string.Join(", ", digits)); 

        int sumOfDigits = NumberChecker.SumOfDigits(digits); 
        Console.WriteLine("Sum of digits: " + sumOfDigits); 

        int sumOfSquaresOfDigits = NumberChecker.SumOfSquaresOfDigits(digits); 
        Console.WriteLine("Sum of squares of digits: " + sumOfSquaresOfDigits); 

        bool isHarshad = NumberChecker.IsHarshadNumber(number); 
        Console.WriteLine("Is Harshad Number: " + isHarshad); 

        int[,] digitFrequency = NumberChecker.FindDigitFrequency(number); 
        Console.WriteLine("Digit frequency:"); 
        for (int i = 0; i < 10; i++) 
        { 
            if (digitFrequency[i, 1] > 0) 
            { 
                Console.WriteLine("Digit " + digitFrequency[i, 0] + ": " + digitFrequency[i, 1] + " times"); 
            } 
        } 
    } 
}
