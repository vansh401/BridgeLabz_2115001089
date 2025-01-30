using System;

public static class NumberChecker 
{
    public static bool IsPrime(int number) 
    { 
        if (number <= 1) return false; 
        for (int i = 2; i <= Math.Sqrt(number); i++) 
        { 
            if (number % i == 0) return false; 
        } 
        return true; 
    } 

    public static bool IsNeon(int number) 
    { 
        int square = number * number; 
        int sumOfDigits = SumOfDigits(square); 
        return sumOfDigits == number; 
    } 

    public static bool IsSpy(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        int sumOfDigits = SumOfDigits(digits); 
        int productOfDigits = ProductOfDigits(digits); 
        return sumOfDigits == productOfDigits; 
    } 

    public static bool IsAutomorphic(int number) 
    { 
        int square = number * number; 
        return square.ToString().EndsWith(number.ToString()); 
    } 

    public static bool IsBuzz(int number) 
    { 
        return number % 7 == 0 || number % 10 == 7; 
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

    public static int SumOfDigits(int number) 
    { 
        int sum = 0; 
        while (number > 0) 
        { 
            sum += number % 10; 
            number /= 10; 
        } 
        return sum; 
    } 

    public static int SumOfDigits(int[] digits) 
    { 
        int sum = 0; 
        for (int i = 0; i < digits.Length; i++) 
        { 
            sum += digits[i]; 
        } 
        return sum; 
    } 

    public static int ProductOfDigits(int[] digits) 
    { 
        int product = 1; 
        for (int i = 0; i < digits.Length; i++) 
        { 
            product *= digits[i]; 
        } 
        return product; 
    } 
}

class NumCheckSpyBuzz 
{
    static void Main() 
    { 
        int number = 153; 
        
        Console.WriteLine("Is Prime: " + NumberChecker.IsPrime(number)); 
        Console.WriteLine("Is Neon: " + NumberChecker.IsNeon(number)); 
        Console.WriteLine("Is Spy: " + NumberChecker.IsSpy(number)); 
        Console.WriteLine("Is Automorphic: " + NumberChecker.IsAutomorphic(number)); 
        Console.WriteLine("Is Buzz: " + NumberChecker.IsBuzz(number)); 
    } 
}
