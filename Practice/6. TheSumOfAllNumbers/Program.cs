using System;

class Program
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