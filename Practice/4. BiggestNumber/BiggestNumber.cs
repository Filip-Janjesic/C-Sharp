using System;

class BiggestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth number: ");
        int d = int.Parse(Console.ReadLine());

        int biggest = Math.Max(a , Math.Max(b, Math.Max(c, d)));
        Console.WriteLine($"The biggest number is: {biggest}");
    }
}
// This program prompts the user to enter four numbers, reads the input, converts it to integers, and then determines and displays the largest of the four numbers using the Math.Max method.