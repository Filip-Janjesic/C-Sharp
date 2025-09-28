using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;

        switch (op)
        {
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result = a * b;
                break;
            case "/":
                if (b != 0)
                    result = a / b;
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation.");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
}
// This is a simple calculator program that performs basic arithmetic operations.