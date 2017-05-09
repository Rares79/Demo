//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace Telerik.Array.Ex_02.CompareTwoArraysLexicograpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert string number one: ");
            string firstString = Console.ReadLine();

            Console.WriteLine("Insert string number two: ");
            string secondString = Console.ReadLine();

            int sizeOfFirstString = firstString.Length;
            int sizeOfSecondString = secondString.Length;
            int minimumSize = Math.Min(sizeOfFirstString, sizeOfSecondString);

            // RV: extrat method
            for (int i = 0; i < minimumSize; i++)
            {
                // RV: if you use continue there is no need of else
                if (firstString[i] == secondString[i])
                {
                    continue;
                }
                // RV: why not create a string textToDisplay with the string that you want to print and call
                // console.writeline only one time
                // string result = firstString[i] < secondString[i] ? "A" : "B";
                else if (firstString[i] < secondString[i])
                {
                    Console.WriteLine(firstString + " este inainte de " + secondString);
                }
                else
                {
                    Console.WriteLine(secondString + " este inainte de " + firstString);
                }
                // RV: formating
            }
            if (firstString == secondString)
            {
                Console.WriteLine("Stringurile sunt identice");
            }
            else if (sizeOfFirstString < sizeOfSecondString)
            {
                Console.WriteLine(firstString + " este inainte de " + secondString);
            }

            else

            {
                Console.WriteLine(secondString + " este inainte de " + firstString);
            }
            Console.ReadLine();

        }
    }
}
