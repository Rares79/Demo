using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
           for (int i=0;i<array.Length;i++ )
            Console.WriteLine("element[{0}]={1}",i,array [i]);
            Console.ReadKey(); 
        }
    }
}
