using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine($"{year} is a leap year.");
        else
            Console.WriteLine($"{year} is not a leap year.");
    }
}
// This program checks if a given year is a leap year or not.