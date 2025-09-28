using System;

public class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
// This program prints "Hello, World!" to the console, then reads a name input from the user and greets them with "Hello, [name]!".