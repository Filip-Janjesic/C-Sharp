using System;

class EvenOrOddNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
// This program prompts the user to enter a number, reads the input, converts it to an integer, and then checks if the number is even or odd by using the modulus operator. It then displays the result accordingly.