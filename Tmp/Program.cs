using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdceti cuvantul:");
            string cuvant = Console.ReadLine();
            int lungime = cuvant.Length ;
            string[] lista = new string[lungime];

            Console.WriteLine(lungime);
            Console.ReadLine();

            for (int i=0;i<lungime;i++ )

            {
                
                Console.WriteLine(cuvant[i]);
            }
            Console.ReadLine();
        }
    }
}
