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

    public static int[] ReverseDigitsArray(int[] digits) 
    { 
        Array.Reverse(digits); 
        return digits; 
    } 

    public static bool AreArraysEqual(int[] array1, int[] array2) 
    { 
        if (array1.Length != array2.Length) 
        { 
            return false; 
        } 
        for (int i = 0; i < array1.Length; i++) 
        { 
            if (array1[i] != array2[i]) 
            { 
                return false; 
            } 
        } 
        return true; 
    } 

    public static bool IsPalindrome(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        int[] reversedDigits = ReverseDigitsArray((int[])digits.Clone()); 
        return AreArraysEqual(digits, reversedDigits); 
    } 

    public static bool IsDuckNumber(int number) 
    { 
        int[] digits = GetDigitsArray(number); 
        for (int i = 0; i < digits.Length; i++) 
        { 
            if (digits[i] != 0) 
            { 
                return true; 
            } 
        } 
        return false; 
    } 
}

class NumCheckArrayDuck 
{
    static void Main() 
    { 
        int number = 12321; 
        
        int digitCount = NumberChecker.CountDigits(number); 
        Console.WriteLine("Count of digits: " + digitCount); 
        
        int[] digits = NumberChecker.GetDigitsArray(number); 
        Console.WriteLine("Digits array: " + string.Join(", ", digits)); 
        
        int[] reversedDigits = NumberChecker.ReverseDigitsArray((int[])digits.Clone()); 
        Console.WriteLine("Reversed digits array: " + string.Join(", ", reversedDigits)); 
        
        bool areArraysEqual = NumberChecker.AreArraysEqual(digits, reversedDigits); 
        Console.WriteLine("Are original and reversed arrays equal? " + areArraysEqual); 
        
        bool isPalindrome = NumberChecker.IsPalindrome(number); 
        Console.WriteLine("Is Palindrome: " + isPalindrome); 
        
        bool isDuckNumber = NumberChecker.IsDuckNumber(number); 
        Console.WriteLine("Is Duck Number: " + isDuckNumber); 
    } 
}
