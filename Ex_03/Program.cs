//Write a program that compares two char arrays lexicographically (letter by letter).

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

            // RV: naming
            int size1 = string1.Length;
            int size2 = string2.Length;
            int minim = Math.Min(size1, size2);

            // RV: extrat method
            for (int i = 0; i < minim; i++)
            {
                // RV: if you use continue there is no need of else
                if (string1[i] == string2[i])
                {
                    continue;
                }
                // RV: why not create a string textToDisplay with the string that you want to print and call
                // console.writeline only one time
                // string result = string1[i] < string2[i] ? "A" : "B";
                else if (string1[i] < string2[i])
                {
                    Console.WriteLine(string1 + " este inainte de " + string2);
                }
                else
                {
                    Console.WriteLine(string2 + " este inainte de " + string1);
                }
                // RV: formating
            }
            if (string1==string2)
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
