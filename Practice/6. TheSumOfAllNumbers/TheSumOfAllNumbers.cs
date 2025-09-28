using System;

class TheSumOfAllNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of 1 to {n} is: {sum}");
    }
}
// This program prompts the user to enter a number n, reads the input, converts it to an integer, and then calculates and displays the sum of all integers from 1 to n using a for loop.