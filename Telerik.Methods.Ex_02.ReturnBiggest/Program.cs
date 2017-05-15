//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

namespace Telerik.Methods.Ex_02.ReturnBiggest
{
    class Program
    {
        private static int GetMaxFromArray(int[] array)
        {
            // RV: I challenge you to find the C# functions that do this automatically. You don't need to replace the code, just look for it. 
            int maximum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }
        static int ReadIntegerFromConsole(string message)
        {
            Console.Write(message);
            string line = Console.ReadLine();
            return int.Parse(line);
        }
        static void Main()
        {
            int[] arrayToCompare = new int[3];
            Console.Write("Please insert array's elements (3):");
            Console.WriteLine();

            for (int i = 0; i < arrayToCompare.Length; i++)
            {
                // RV: GetInteger. If you reuse code, why not create a common library.
                arrayToCompare[i] = ReadIntegerFromConsole($"Please insert the element {i}:");
            }

            Console.WriteLine("The bigger number is {0}", GetMaxFromArray(arrayToCompare));
            Console.ReadLine();
        }
    }
}



