using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci numbers up to " + n + ":");

        int a = 0, b = 1;
        while (a <= n)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }
}
