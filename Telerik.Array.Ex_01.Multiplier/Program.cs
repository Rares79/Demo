namespace Telerik.Array.Ex_01.Multiplier
{    //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
    using System;
    class Program
    {
        static class Constants
        {
            public const int arraysize = 20;
            public const int multiplier = 5;
        }
        static void Main(string[] args)
        {
            int[] arrayToMultiply = new int[Constants.arraysize];
            MultiplyArray(arrayToMultiply);
            PrintArray(arrayToMultiply);
        }
        private static void MultiplyArray(int[] arrayToMultiply)
        {
            for (int i = 0; i < Constants.arraysize; i++)
            {
                arrayToMultiply[i] = i * Constants.multiplier;
            }
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
