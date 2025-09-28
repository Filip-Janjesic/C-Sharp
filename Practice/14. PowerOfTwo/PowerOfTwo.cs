using System;

class PowerOfTwo
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        string message = IsPowerOfTwo(n)
            ? "Yes, it is a power of two."
            : "No, it is not a power of two.";

        Console.WriteLine(message);
    }

    static bool IsPowerOfTwo(int n)
    {
        if (n <= 0) return false;
        while (n > 1)
        {
            if (n % 2 != 0) return false;
            n /= 2;
        }
        return true;
    }
}
// This code checks if a given integer is a power of two.