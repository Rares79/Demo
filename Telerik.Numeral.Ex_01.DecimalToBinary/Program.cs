using System;

namespace Telerik.Numeral.Ex_01.DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.
    class Program
    {
        static void Main(string[] args)
        {
            int numberToConvert;
            Console.WriteLine("Please insert the number for conversion:");
            numberToConvert = int.Parse(Console.ReadLine());
            string numberConvertedInBinary = Convert.ToString(numberToConvert, 2);
            Console.WriteLine(numberConvertedInBinary);
            Console.ReadLine();
        }
    }
}
