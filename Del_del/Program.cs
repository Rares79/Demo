using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_del
{
    class Program
    {
        private static int ExtractLastDigit(string numberAsString)
        {
            return Int32.Parse(numberAsString.Substring(numberAsString.Length - 1, 1));
        }
        static void Main(string[] args)
        {
            string[] digit= new string[] { "zero", "one", "two", "three", "four", "five", "six","seven","eight","nine" };
            string numberAsString;
            int lastDigit;
            Console.WriteLine("Please insert a number (integer)");
            numberAsString = Console.ReadLine();
            lastDigit = ExtractLastDigit(numberAsString);
            Console.WriteLine(digit [lastDigit]);
            Console.ReadKey();
        }
    }
}
