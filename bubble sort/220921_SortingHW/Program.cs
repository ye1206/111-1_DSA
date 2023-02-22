// 110213076 鄭鈺曄
using System;
using ClassLibrary_Cheng3001.Algorithm;

namespace _220921_SortingHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // for loop
            int j = 0; //for loop
            int temp = 0;
            Random rnd = new Random(); //Random variable
            int ran = rnd.Next(10, 21);

            int[] data = new int[ran];

            Console.WriteLine($"總共{ran} 筆資料\n\n原本的順序:\n");

            for (i = 0; i < data.Length; i++) // generate an array between -50 and 50 
            {
                data[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", data[i]);
            }

            Console.WriteLine();

            Console.WriteLine("\n排序後的順序: \n");

            Sorting.BubblieSort(data);

            //for (i = 0; i < data.Length; i++) //Bubble sorting
            //{
            //    for (j = 0; j < data.Length - 1  ; j++)
            //    {
            //        while (data[j] > data[j + 1])
            //        {
            //            temp = data[j];
            //            data[j] = data[j + 1];
            //            data[j + 1] = temp;
            //        }
            //    }
            //    foreach (var item in data)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //} // end of outer loop

            Console.WriteLine("\n最終順序: \n");

            for (i = 0; i < data.Length; i++) //Bubble sorting
            {
                Console.Write("{0} ", data[i]);
            } // end of outer loop

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
