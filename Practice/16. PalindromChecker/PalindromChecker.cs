using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a word: ");
        string input = Console.ReadLine();
        string reversed = new string(input.ToCharArray().Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}
// This code checks if a given word is a palindrome.