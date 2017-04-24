using System;

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

            for (int i = 0; i < minim; i++)
            {
                if (string1[i] == string2[i])
                {
                    continue;
                }
                else if (string1[i] < string2[i])
                {
                    Console.WriteLine(string1 + " este inainte de " + string2);
                }
                else
                {
                    Console.WriteLine(string2 + " este inainte de " + string1);
                }
            }
               if(string1==string2)
            {
                Console.WriteLine("Stringurile sunt identice");
            }
               else if (size1<size2)
            {
                Console.WriteLine(string1 + " este inainte de " + string2);

            }
              
             else

            { 
                Console.WriteLine(string2 + " este inainte de " + string1);
            }
            Console.ReadLine();

            }
        }
    }
