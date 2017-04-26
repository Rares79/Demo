using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // RV: Size of what 1,2, try to five more explicit names
            int size1;
            int size2;

            // RV: Try to use english, not Romanian
            Console.Write("Introduceti marimea array1 (numar):");
            size1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[size1];
            // RV: same as for Ex_1, project name, use methoods
            for (int i = 0; i < myArray1.Length; i++)
            {
                // RV: ReadIntegerFromConsole would be a better name
                // RV: Use String.format or other similar mechanism to format strings
                // RV string txtToRequired... = $"Enter text: {i}";
                myArray1[i]  = ReadInt32FromConsole("Introduceti elementul " + i);
               
            }
            // RV: Why this extra space?



            Console.Write("Introduceti marimea array2 (numar):");
            size2 = int.Parse(Console.ReadLine());
            // RV: naming of myarray2....
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
                // RV: never and never use an else without {}!!!!
                for (int i = 0; i < size1; i++)
            {
                if (myArray1[i] != myArray2[i])
                {
                        // RV: formating
                        // RV: there is no purpose of brake in this case
                        // RV: Console.WriteLine("dsds {0}  dsds", i);
                        Console.WriteLine("Elementul "+i +"sunt diferite");
                        break;

                }
                    Console.WriteLine("Elementul " + i + "sunt identice");
                   

                }


            Console.ReadKey();

        }
        static int ReadInt32FromConsole(string message)
        {
            // RV: string format
            // RV: You don't need two Write. Only one write with string.format   and https://msdn.microsoft.com/en-us/library/34f6bwz3(v=vs.110).aspx                   
            Console.Write(": ");
            string line = Console.ReadLine();
            return int.Parse(line);
        }
    }
}


