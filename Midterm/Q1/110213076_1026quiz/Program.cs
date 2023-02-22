using System;

namespace _110213076_1026quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("110213076  鄭鈺曄\n");

            #region global
            int[] data = new int[6];
            data[5] = 76;

            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);
            Console.Write("原始資料: ");
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                data[i] = rnd.Next(50, 61);
                Console.Write(data[i].ToString().PadLeft(4));
            }
            Console.Write(data[5].ToString().PadLeft(4));
            Console.WriteLine();

            int min_position;
            int temp;

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
                Console.WriteLine("\n");
            } //outer loop
            #endregion Selection Sort


            #endregion global
            Console.WriteLine("");
            Console.Read();
        }
    }
}
