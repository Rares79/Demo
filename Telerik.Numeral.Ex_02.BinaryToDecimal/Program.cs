//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Numeral.Ex_02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberToConvert;
            Console.WriteLine("Please insert the number for conversion:");
            numberToConvert =Console.ReadLine();
            int numberConvertedInDecimal = Convert.ToInt32(numberToConvert,2);
            Console.WriteLine(numberConvertedInDecimal);
            Console.ReadLine();
        }
    }
}
