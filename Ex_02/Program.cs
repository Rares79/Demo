//Write a program that reads two arrays from the console and compares them element by element.


using System;
namespace Telerik.Array.Ex_02.CompareTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFirstArry;
            int sizeOfSecondArray;


            Console.Write("Please insert the size of the first array (number):");
            sizeOfFirstArry = int.Parse(Console.ReadLine());
            int[] firstArray = new int[sizeOfFirstArry];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = ReadIntegerFromConsole($"Please insert the element {i}:");
            }

            Console.Write("Please insert the size of the second array (number):");
            sizeOfSecondArray = int.Parse(Console.ReadLine());

            int[] secondArray = new int[sizeOfSecondArray];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = ReadIntegerFromConsole($"Please insert the element {i}:");

            }
            if (sizeOfFirstArry != sizeOfSecondArray)
            {
                Console.WriteLine("The arrays are different due to the number of elements");
                Console.ReadLine();
            }
            else
            {

                for (int i = 0; i < sizeOfFirstArry; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The element {0} is diferent", i);
                    }
                    Console.WriteLine("Arrays size are identical");
                }
            }
            Console.ReadKey();
        }
        static int ReadIntegerFromConsole(string message)
        {
            Console.Write(message);
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}


