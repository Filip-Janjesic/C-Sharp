using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
            return;
        }

        Console.WriteLine($"Factorial (Iterative): {FactorialIterative(n)}");
        Console.WriteLine($"Factorial (Recursive): {FactorialRecursive(n)}");
    }

    static BigInteger FactorialIterative(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static BigInteger FactorialRecursive(int n)
    {
        if (n <= 1) return 1;
        return n * FactorialRecursive(n - 1);
    }
}
// This program calculates the factorial of a non-negative integer using both iterative and recursive methods.