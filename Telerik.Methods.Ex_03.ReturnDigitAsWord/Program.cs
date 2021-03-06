﻿//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
using System;

namespace Telerik.Methods.Ex_03.ReturnDigitAsWord
{
    class Program
    {
        private static int ExtractLastDigit(string numberAsString)
        {
            return Int32.Parse(numberAsString.Substring(numberAsString.Length - 1, 1));
        }
        static void Main()
        {
            string[] digit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string numberAsString;
            int lastDigit;
            Console.WriteLine("Please insert a number (integer)");
            numberAsString = Console.ReadLine();
            lastDigit = ExtractLastDigit(numberAsString);
            Console.WriteLine(digit[lastDigit]);
            Console.ReadKey();
        }
    }
}
