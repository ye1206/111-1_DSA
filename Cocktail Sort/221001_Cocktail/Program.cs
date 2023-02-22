// 110213076 鄭鈺曄
using System;
using ClassLibrary_Cheng3001.Algorithm;

namespace _221001_Cocktail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region global
            int i = 0; // for loop
            int j = 0; //for loop
            int k = 0;
            int temp = 0;
            int start = 0;

            Random rnd = new Random(); //Random variable
            int ran = rnd.Next(10, 21);

            int[] data = new int[ran];
            int end = data.Length;
            #endregion global

            Console.WriteLine("Cocktail Sort");

            Console.WriteLine($"總共{ran} 筆資料\n\n原本的順序:\n");

            for (i = 0; i < data.Length; i++) // generate an array between -50 and 50 
            {
                data[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", data[i]);
            }

            Console.WriteLine();

            Console.WriteLine("\n排序後的順序: \n");

            Sorting.Cocktail(data);

            //for (i = start; i < end - 1; i++) //sort
            //{
            //    for (j = start; j < end - 1; j++) // 由小到大排序 
            //    {
            //        while (data[j] > data[j + 1])
            //        {
            //            temp = data[j];
            //            data[j] = data[j + 1];
            //            data[j + 1] = temp;
            //        }
            //    } 

            //    end = end - 1;

            //    for (j = end; j > start; j--) // 從數列尾由大到小排序
            //    {
            //        while (data[j] < data[j - 1])
            //        {
            //            temp = data[j];
            //            data[j] = data[j - 1];
            //            data[j - 1] = temp;
            //        }
            //    }

            //    start = start + 1;

            //    Console.Write("第 {0} 回合排序\t", i + 1);
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
