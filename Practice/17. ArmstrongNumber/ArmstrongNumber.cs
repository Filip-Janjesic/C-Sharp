using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0, temp = num;
        int digits = num.ToString().Length;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }

        if (sum == num)
            Console.WriteLine($"{num} is an Armstrong number.");
        else
            Console.WriteLine($"{num} is not an Armstrong number.");
    }
}
// This code checks if a number is an Armstrong number by calculating the sum of its digits raised to the power of the number of digits and comparing it to the original number.