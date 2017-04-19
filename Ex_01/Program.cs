using System;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int multiplier = 5;

            int[] myArray = new int[size];
            
            for(int i=0;i<size;i++)
            {
                myArray[i] = i * multiplier; 
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                
            }
            Console.ReadLine();
        }
    }
}
