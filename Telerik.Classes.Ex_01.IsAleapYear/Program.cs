using System;

namespace Telerik.Classes.Ex_01.IsAleapYear
{
    // Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a year: ");
            string yearToCheckAsString = Console.ReadLine();
            int yearToCheck = Int32.Parse(yearToCheckAsString);
            bool isLeapYear = DateTime.IsLeapYear(yearToCheck);
            Console.WriteLine("This {0} a leap year.", isLeapYear ? "is" : "is not");
            Console.ReadLine();
        }
    }
}