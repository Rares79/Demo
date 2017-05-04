using System;

namespace Telerik.Array.Ex_01.Multiplier
{

    class Program
    {
        static void Main(string[] args)
        {

            int arraysize = 20;
            int multiplier = 5;


            int[] arrayToMultiply = new int[arraysize];


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
