using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti stringul 1: ");
            string string1 = Console.ReadLine();

            Console.WriteLine("Introduceti stringul 2: ");
            string string2 = Console.ReadLine();

            int size1 = string1.Length;
            int size2 = string2.Length;
            int minim = Math.Min(size1, size2);

            Console.WriteLine(minim);
            Console.ReadLine();

        }
    }
}
