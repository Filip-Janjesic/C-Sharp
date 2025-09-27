using System;
class Program
    {
    static void Main()
    {
        Console.WriteLine("Enter the word: ");
        string word = Console.ReadLine().ToLower();
        int count = 0;

        foreach (char c in word)
        
            if ("aeiou".Contains(c))
            {
                count++;
            }

            Console.WriteLine($"Number of vowels: {count}");
        
    }
}