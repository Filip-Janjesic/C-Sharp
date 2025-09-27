using System;

class Program
{
    static void Main()
    {
        Random rand = new ();
        int secretNumber = rand.Next(1, 101);
        int attempts;

        Console.WriteLine("Guess the number between 1 and 100!");

        do
        {
            Console.Write("Enter your guess: ");
            attempts = int.Parse(Console.ReadLine());

            if (attempts < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (attempts > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the number!");
            }
        } while (attempts != secretNumber);
    }
}
// This program generates a random secret number between 1 and 100. It then prompts the user to guess the number, providing feedback on whether the guess is too low, too high, or correct. The process continues until the user guesses the correct number.