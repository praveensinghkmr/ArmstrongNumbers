using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int num = number;
        int sum = 0;
        List<int> digits = new List<int>();

        do
        {
            digits.Add(num % 10);
            num = num/10;
        } while (num != 0);

        foreach(int digit in digits)
        {
            sum = sum + (int)Math.Pow(digit, digits.Count);
        }

        if (sum == number)
            return true;

        return false;
    }
}