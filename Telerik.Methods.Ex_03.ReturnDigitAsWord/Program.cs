//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

namespace Telerik.Methods.Ex_03.ReturnDigitAsWord
{
    class Program
    {
        private static string TransformDigitInWord(int digit)
        {
            switch (digit)
            {
                case 0:
                    {
                        return "zero";
                    }
                case 1:
                    {
                        return "one";
                    }
                case 2:
                    {
                        return "two";
                    }
                case 3:
                    {
                        return "three";
                    }
                case 4:
                    {
                        return "four";
                    }
                case 5:
                    {
                        return "five";
                    }
                case 6:
                    {
                        return "six";
                    }
                case 7:
                    {
                        return "seven";
                    }
                case 8:
                    {
                        return "eight";
                    }
                case 9:
                    {
                        return "nine";
                    }
                default:
                    {
                        return "Not a number!!";
                    }
            }

        }
        private static int ExtractLastDigit(string numberAsString)
        {
            return Int32.Parse(numberAsString.Substring(numberAsString.Length - 1, 1));
        }
        static void Main()
        {
            string numberAsString;
            int lastDigit;
            Console.WriteLine("Please insert a number (integer)");
            numberAsString = Console.ReadLine();
            lastDigit = ExtractLastDigit(numberAsString);
            Console.WriteLine(TransformDigitInWord(lastDigit));
            Console.ReadKey();
        }
    }
}
