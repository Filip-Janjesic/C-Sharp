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