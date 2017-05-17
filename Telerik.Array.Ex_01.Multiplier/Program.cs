using System;

namespace Telerik.Array.Ex_01.Multiplier
{
    // RV: Problem req.?
    class Program
    {
        static void Main(string[] args)
        {
            // RV: Could be declared as const
            int arraysize = 20;
            int multiplier = 5;// RV:  Why you have two new lines under it?
            int[] arrayToMultiply = new int[arraysize];

            // RV: Why not extract this as a method.
            for (int i = 0; i < arraysize; i++)
            {
                arrayToMultiply[i] = i * multiplier;
            }

            PrintArray(arrayToMultiply);
        }

        private static void PrintArray(int[] arrayToMultiply)
        {
            for (int i = 0; i < arrayToMultiply.Length; i++)
            {
                Console.WriteLine(arrayToMultiply[i]);
            }
            Console.ReadLine();
        }
    }
}
