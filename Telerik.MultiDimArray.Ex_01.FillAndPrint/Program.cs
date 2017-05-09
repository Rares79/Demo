//Write a program that fills and prints a matrix of size(n, n) as shown below: (examples for n = 4)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.MultiDimArray.Ex_01.FillAndPrint
{
    class Program
    {
        public static void PrintMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row< matrix.GetLength(0); row++)
            {
                for (int column = 0;row< matrix.GetLength(1); column++)
                {
                    Console.Write("{0,5}", matrix[row, column]);

                }
                Console.WriteLine(); 
            }

            static void Main(string[] args)
            {

            }
        }
    }