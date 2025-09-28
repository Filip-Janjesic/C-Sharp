﻿using System;

class MatrixAddition
{
    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };
        int[,] C = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        Console.WriteLine("Result of matrix addition:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(C[i, j] + " ");
            Console.WriteLine();
        }
    }
}
// This code defines two 2x2 matrices A and B, adds them together element-wise, and stores the result in matrix C. Finally, it prints the resulting matrix C to the console.