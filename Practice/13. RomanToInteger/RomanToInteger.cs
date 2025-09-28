using System;

class RomanToInteger
{
    static void Main()
    {
        Console.WriteLine("Enter roman number: ");
        string roman = Console.ReadLine().ToUpper();

        Console.WriteLine($"Integer value: {RomanToInteger(roman)}");
    }
    static int RomanToInteger(string s)
    {
        int total = 0;
        int prevValue = 0;
        foreach (char c in s)
        {
            int currentValue = c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Invalid Roman numeral character")
            };
            if (currentValue > prevValue)
            {
                total += currentValue - 2 * prevValue;
            }
            else
            {
                total += currentValue;
            }
            prevValue = currentValue;
        }
        return total;
    }
}
// This code converts a Roman numeral string to its integer value.
