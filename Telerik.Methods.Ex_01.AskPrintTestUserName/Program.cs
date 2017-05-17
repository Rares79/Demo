using System;

namespace Telerik.Methods.Ex_01.AskPrintTestUserName
{
    //Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.
    class Program
    {
        private static void GetUserName()
        {
            Console.Write("Please insert your name: ");
            string userNameToPrint = Console.ReadLine();
            Console.WriteLine("Hello {0} !", userNameToPrint);
        }
        static void Main()
        {
            GetUserName();
            Console.ReadLine();
        }
    }
}
