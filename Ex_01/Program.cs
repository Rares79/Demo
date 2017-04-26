using System;

namespace Ex_01
{
    // RV: Project name Ex_01. You should avoid using _ in the naming. 01 might make sense when you start to resolve a problem from a list
    // but if you do next day another one from another book and you have 01 again. 
    // Why not naming the project: 'Ex.Multiplier'. If you want to have 01 you could do 'Ex.01.Multiplier', but in this case it would be
    // nice to add the chapter or book, something like 'Ex.Telerik.Array.01.Multiplier
    class Program
    {
        static void Main(string[] args)
        {
            // RV: Size of what? Rename it arraySize
            int size = 20;
            int multiplier = 5;

            // RV:  why my? what not just array or arrayToMultiple
            int[] myArray = new int[size];

            // RV: formating - space between ;. VS can do this for you cmd+k cmd+d
            for (int i = 0;i<size;i++)
            {
                myArray[i] = i * multiplier;
            }

            // RV: You should start using methods for each step. 
            // PrintArray(...) - similar with the above code
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }
            Console.ReadLine();
        }
    }
}
