using System;
using ClassLibrary_Cheng3001.Algorithm;

namespace _221019_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region global
            int[] data = new int[] { 3, 4, 1, 7, 8};
            Console.Write("排序前的資料".PadLeft(4));
            foreach (int var in data)
                Console.Write(var.ToString().PadLeft(4));
            Console.WriteLine();

            int temp = 0;
            int i, j;
            #endregion global

            Sorting.InsertionSort(data);

            //#region Insertion Sort
            //for (i = 1; i < data.Length; i++)
            //{
            //    temp = data[i];
            //    for (j = i - 1; j >= 0; j--)
            //    {
            //        if (data[j] > temp)
            //        {
            //            data[j + 1] = data[j];
            //            if (j == 0)
            //                data[j] = temp;
            //        }
            //        else
            //        {
            //            data[j + 1] = temp;
            //            break;
            //        }
            //    } // inner loop
            //    Console.Write("第{0}回合排序: ", i);
            //    foreach (int var in data)
            //        Console.Write(var.ToString().PadLeft(4));
            //    Console.WriteLine();
            //} //for
            //#endregion Insertion Sort
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
