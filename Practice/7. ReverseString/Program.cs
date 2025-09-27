using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the word: ");
        string word = Console.ReadLine();
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversedWord = new string(charArray);

        Console.WriteLine("Reversed word: " + reversedWord);
    }
}
// This program prompts the user to enter a word, reads the input, reverses the characters in the word, and then displays the reversed word.