using System;

class AddingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number!");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number!");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"The sum of {a} and {b} is {a + b}");
    }
}
// This program prompts the user to enter two numbers, reads the input, converts it to integers, and then calculates and displays their sum.