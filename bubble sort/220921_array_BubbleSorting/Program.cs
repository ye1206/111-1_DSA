// Goal : Use array and  bubble sorting find the smallest number

using System;
using ClassLibrary_Cheng3001.Algorithm;

namespace _220921_array_BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] data = new int[] { 26, 5, 37, 1, 61, -100, 35};
            int max, min;
            int i = 0;

            Sorting.BubblieSort(data);
                

            

            // max = -Int32.MaxValue; 
            // min = Int32.MaxValue;

            // The other way
            //max = data[0];
            //min = data[0];

            //for (i = 0; i < data.Length; i++)
            //{
            //    if (data[i] > max)
            //        max = data[i];
            //    if (data[i] < min)
            //        min = data[i];
            //}

            //Console.WriteLine("The biggest number = {0} and the smallest number = {1}", max, min);
            Console.WriteLine("\nPress key to continue...");
        }
    }
}
