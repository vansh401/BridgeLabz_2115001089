using System;

public static class NumberChecker 
{
    public static int[] FindFactors(int number) 
    { 
        int count = 0; 
        for (int i = 1; i <= number; i++) 
        { 
            if (number % i == 0) 
            { 
                count++; 
            } 
        } 
        int[] factors = new int[count]; 
        int index = 0; 
        for (int i = 1; i <= number; i++) 
        { 
            if (number % i == 0) 
            { 
                factors[index++] = i; 
            } 
        } 
        return factors; 
    } 

    public static int FindGreatestFactor(int[] factors) 
    { 
        int greatest = factors[0]; 
        for (int i = 0; i < factors.Length; i++) 
        { 
            if (factors[i] > greatest) 
            { 
                greatest = factors[i]; 
            } 
        } 
        return greatest; 
    } 

    public static int SumOfFactors(int[] factors) 
    { 
        int sum = 0; 
        for (int i = 0; i < factors.Length; i++) 
        { 
            sum += factors[i]; 
        } 
        return sum; 
    } 

    public static int ProductOfFactors(int[] factors) 
    { 
        int product = 1; 
        for (int i = 0; i < factors.Length; i++) 
        { 
            product *= factors[i]; 
        } 
        return product; 
    } 

    public static double ProductOfCubeOfFactors(int[] factors) 
    { 
        double product = 1; 
        for (int i = 0; i < factors.Length; i++) 
        { 
            product *= Math.Pow(factors[i], 3); 
        } 
        return product; 
    } 

    public static bool IsPerfectNumber(int number) 
    { 
        int[] factors = FindFactors(number); 
        int sum = SumOfFactors(factors) - number; 
        return sum == number; 
    } 

    public static bool IsAbundantNumber(int number) 
    { 
        int[] factors = FindFactors(number); 
        int sum = SumOfFactors(factors) - number; 
        return sum > number; 
    } 

    public static bool IsDeficientNumber(int number) 
    { 
        int[] factors = FindFactors(number); 
        int sum = SumOfFactors(factors) - number; 
        return sum < number; 
    } 

    public static bool IsStrongNumber(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        int sumOfFactorials = 0; 
        for (int i = 0; i < digits.Length; i++) 
        { 
            sumOfFactorials += Factorial(digits[i]); 
        } 
        return sumOfFactorials == number; 
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

    public static int Factorial(int number) 
    { 
        if (number == 0 || number == 1) 
        { 
            return 1; 
        } 
        return number * Factorial(number - 1); 
    } 
}

class NumCheckDeficientStrong 
{
    static void Main() 
    { 
        int number = 28; 
        
        int[] factors = NumberChecker.FindFactors(number); 
        Console.WriteLine("Factors: " + string.Join(", ", factors)); 
        
        int greatestFactor = NumberChecker.FindGreatestFactor(factors); 
        Console.WriteLine("Greatest Factor: " + greatestFactor); 
        
        int sumOfFactors = NumberChecker.SumOfFactors(factors); 
        Console.WriteLine("Sum of Factors: " + sumOfFactors); 
        
        int productOfFactors = NumberChecker.ProductOfFactors(factors); 
        Console.WriteLine("Product of Factors: " + productOfFactors); 
        
        double productOfCubeOfFactors = NumberChecker.ProductOfCubeOfFactors(factors); 
        Console.WriteLine("Product of Cube of Factors: " + productOfCubeOfFactors); 
        
        bool isPerfectNumber = NumberChecker.IsPerfectNumber(number); 
        Console.WriteLine("Is Perfect Number: " + isPerfectNumber); 
        
        bool isAbundantNumber = NumberChecker.IsAbundantNumber(number); 
        Console.WriteLine("Is Abundant Number: " + isAbundantNumber); 
        
        bool isDeficientNumber = NumberChecker.IsDeficientNumber(number); 
        Console.WriteLine("Is Deficient Number: " + isDeficientNumber); 
        
        bool isStrongNumber = NumberChecker.IsStrongNumber(number); 
        Console.WriteLine("Is Strong Number: " + isStrongNumber); 
    } 
}
