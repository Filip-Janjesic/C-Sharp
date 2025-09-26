using System;

class Program
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