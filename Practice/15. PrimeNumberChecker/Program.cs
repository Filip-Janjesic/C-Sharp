using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n)
            ? "The number is prime."
            : "The number is not prime.");

        Console.WriteLine($"Prime numbers up to {n}:");
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i)) Console.Write(i + " ");
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
