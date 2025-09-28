using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
// This program prompts the user to enter a number, reads the input, converts it to an integer, and then prints the multiplication table for that number from 1 to 10 using a for loop.