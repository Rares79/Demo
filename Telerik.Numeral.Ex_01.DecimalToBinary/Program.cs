//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Numeral.Ex_01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // RV: Are you sure that this was the requirment? I think that you should use the 'manual' conversion. 
            int numberToConvert;
            Console.WriteLine("Please insert the number for conversion:");
            numberToConvert = int.Parse(Console.ReadLine());
            string numberConvertedInBinary = Convert.ToString(numberToConvert, 2);
            Console.WriteLine(numberConvertedInBinary);
            Console.ReadLine();
        }
    }
}
