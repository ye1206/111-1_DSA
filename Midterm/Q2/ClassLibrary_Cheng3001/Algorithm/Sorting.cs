using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.Algorithm
{
    public class Sorting
    {
        public static int i = 0; // for loop
        public static int j = 0; //for loop
        public static int k = 0;
        public static int temp = 0;
        public static int start = 0;

        public static void BubblieSort(int[] data)
        {
            int max, min;

            // max = -int32.maxvalue; 
            // min = int32.maxvalue;

            // the other way
            max = data[0];
            min = data[0];

            for (i = 0; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
                if (data[i] < min)
                    min = data[i];
            } //for



        } //BubbleSort

        public static void Cocktail(int[] data)
        {
            int end = data.Length;

            for (i = start; i < end - 1; i++) //sort
            {
                for (j = start; j < end - 1; j++) // 由小到大排序 
                {
                    while (data[j] > data[j + 1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }

                end = end - 1;

                for (j = end; j > start; j--) // 從數列尾由大到小排序
                {
                    while (data[j] < data[j - 1])
                    {
                        temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                }

                start = start + 1;

                Console.Write("第 {0} 回合排序\t", i + 1);
                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            } // end of outer loop
        }
    }
}
