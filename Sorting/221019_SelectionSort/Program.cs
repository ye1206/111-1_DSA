using System;
using ClassLibrary_Cheng3001.Algorithm;

namespace _221019_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region global
            int[] data = new int[] { 123, 23, 98, 41, -2, 69 };
            int i = 0, j = 0;
            int min_position = 0, temp = 0;

            #endregion global

            Console.Write("原始資料 ");
            foreach (int var in data)
                Console.Write(var.ToString().PadLeft(4));
            Console.WriteLine("\n");

            Sorting.SelectionSort(data);

            #region Selection Sort
            //for (i = 0; i < data.Length - 1; i++)
            //{
            //    min_position = i;
            //    for (j = i + 1; j < data.Length; j++)
            //    {
            //        if (data[j] < data[min_position])  //如果發現[j]的數字比[min_position]的數字小，就將j取代min_position 
            //            min_position = j;  //remember the position
            //    } // inner loop

            //    temp = data[i];
            //    data[i] = data[min_position];
            //    data[min_position] = temp;   // 25-27行即完成一回合的交換

            //    Console.Write($"第{i + 1}回合排序結果\t");

            //    for (j = 0; j < data.Length; j++)
            //        Console.Write($"{data[j].ToString().PadLeft(4)}");
            //    Console.WriteLine("\n");
            //} //outer loop
            #endregion Selection Sort

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
