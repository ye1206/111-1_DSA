using System;
using System.IO;

namespace _110213076_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            #region global
            StreamReader fileReader = new StreamReader("data.txt"); // reads data from a text file
            string[] file = fileReader.ReadLine().Split(",");

            Console.Write("排序前的資料".PadLeft(4));

            int[] data = new int[file.Length];
            int i, j;
            for (i = 0; i < file.Length; i++)
                data[i] = int.Parse(file[i]);

            foreach (int var in data)
                Console.Write(var.ToString().PadLeft(4));
            Console.WriteLine();

            Console.WriteLine();

            int min_position = 0, temp = 0;

            #endregion global

  
            #region Selection Sort
            for (i = 0; i < data.Length - 1; i++)
            {
                min_position = i;
                for (j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min_position])  //如果發現[j]的數字比[min_position]的數字小，就將j取代min_position 
                        min_position = j;  //remember the position
                } // inner loop

                temp = data[i];
                data[i] = data[min_position];
                data[min_position] = temp;   // 25-27行即完成一回合的交換

                Console.Write($"第{i + 1}回合排序結果\t");

                for (j = 0; j < data.Length; j++)
                    Console.Write($"{data[j].ToString().PadLeft(4)}");
                Console.WriteLine();
            } //outer loop
            #endregion Selection Sort

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
