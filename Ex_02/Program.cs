using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int size1;
            int size2;

            Console.Write("Introduceti marimea array1 (numar):");
            size1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[size1];
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i]  = ReadInt32FromConsole("Introduceti elementul " + i);
               
            }

           
           

            Console.Write("Introduceti marimea array2 (numar):");
            size2 = int.Parse(Console.ReadLine());
            int[] myArray2 = new int[size2];
            for (int i = 0; i < myArray2.Length; i++)
            {
                myArray2[i] = ReadInt32FromConsole("Introduceti elementul " + i);

            }
            if (size1 != size2)
            {
                Console.WriteLine("Sunt diferite ca si numar de elemente");
                Console.ReadLine();
            }
            else

            for (int i = 0; i < size1; i++)
            {
                if (myArray1[i] != myArray2[i])
                {
                    Console.WriteLine("Elementul "+i +"sunt diferite");
                        break;

                }
                    Console.WriteLine("Elementul " + i + "sunt identice");
                   

                }


            Console.ReadKey();

        }
        static int ReadInt32FromConsole(string message)
        {
            Console.Write(message);
            Console.Write(": ");
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}


