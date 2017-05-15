// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace Telerik.Classes.Ex_01.IsAleapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // RV: You can declare this variable only in the place where you need them.
            int yearToCheck;
            bool isLeapYear;
            Console.WriteLine("Please insert a year: ");
            // RV: Try to not combine ReadLine with int.Parse. Is more complicated when you debug it. Write this two actions on separate lines
            yearToCheck = int.Parse (Console.ReadLine());
            isLeapYear = DateTime.IsLeapYear(yearToCheck);
            Console.WriteLine("This {0} a leap year.", isLeapYear ? "is" : "is not");
            Console.ReadLine(); 
        }
    }
}