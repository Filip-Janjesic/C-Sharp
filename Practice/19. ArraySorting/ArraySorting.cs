using System;

class ArraySorting
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
    }
}
// This code implements a simple bubble sort algorithm to sort an array of integers in ascending order.