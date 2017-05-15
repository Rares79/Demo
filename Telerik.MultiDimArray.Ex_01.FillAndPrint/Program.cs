//Write a program that fills and prints a matrix of size(n, n) as shown below: (examples for n = 4)


using System;

namespace Telerik.MultiDimArray.Ex_01.FillAndPrint
{
    class Program
    {
        // RV: What is A?B
        public static void MatrixA(int[,] matrix, int n)
        {
            // RV: This could be const. at class level.
            int valueToFill = 1;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, column] = valueToFill++;
                }
            }

            // RV: I would call print outside this method.
            PrintMatrix(matrix, n);
        }
        public static void MatrixB(int[,] matrix, int n)
        {
            // Same comments as for MatrixA
            int valueToFill = 1;
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if ((column % 2) == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, column] = valueToFill++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, column] = valueToFill++;
                    }
                }
            }
            PrintMatrix(matrix, n);
        }

        public static void PrintMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the value for n: ");

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            MatrixA(matrix, n);
            Console.WriteLine();

            MatrixB(matrix, n);
            Console.ReadLine();
        }
    }
}
