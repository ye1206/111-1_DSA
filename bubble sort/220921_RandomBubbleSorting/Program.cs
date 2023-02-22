/* Goal: generate a random integer between [10, 20] as the length of the data array and
               fill the content of the data using the random integer between [-50, 50] with bubble sort algorithm to order*/
using System;

namespace _220921_RandomBubbleSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // for loop
            int j = 0; //for loop
            int temp = 0;
            Random rnd = new Random(); //Random variable
            int ran = rnd.Next(10, 21); 

            int[] data = new int[ran];

            for (i = 0; i < data.Length; i++) // generate an array between -50 and 50 
            {
                data[i] = rnd.Next(-50, 51);
                Console.Write("{0}, ", data[i]);
            }

            for (i = 0; i < data.Length; i++) //Bubble sorting
            {
                for (j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            } // end of outer loop

            Console.WriteLine($"\n總共{ran} 筆資料\n");

            Console.WriteLine($"排序後的順序: \n");

            for (i = 0; i < data.Length; i++)
            {
                if (i != data.Length - 1)
                    Console.Write($"{data[i]}, ");
                else
                    Console.Write(data[i]);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
