using System;
using ClassLibrary_Cheng3001.DSA;

namespace MagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the N (must be an odd): ");
            int num = int.Parse(Console.ReadLine());

            MagicMatrix.Square(num);


            //#region global
            //int i = 0, j = 0;
            //Console.Write("Input the N: ");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine($"\n N = {N} 的魔術方陣\n");
            //int[,] Magic = new int[N, N];  // 宣告方陣
            //int n = N - 1;
            //int row = 0, column = (N - 1) / 2; // 取得最中間的格數
            //int Key = 1; //key 表填入的數字，以1為首個數字
            //#endregion global

            #region Magic Square
            //for (i = 0; i < N; i++)    // 初始化方陣
            //    for (j = 0; j < N; j++)
            //        Magic[i, j] = 0;

            //Magic[row, column] = Key++;

            //for (i = Key; i <= N * N; i++) //開始運作
            //{
            //    row = row - 1; //計算下個數值的位置
            //    column = column - 1; // 計算下個數值的位置

            //    if ((row < 0) && (column >= 0))
            //        row = n;
            //    else
            //    {
            //        if ((row >= 0) && (column < 0))
            //            column = n;
            //        else  //((row < 0) && (column < 0))
            //        {
            //            if ((row < 0) && (column < 0))
            //            {
            //                row = row + 2;
            //                column = column + 1;
            //            }
            //        } // inner else
            //    } //outer else

            //    if (Magic[row, column] != 0) //檢驗格子內是否有填數字
            //    {
            //        row = row + 2;
            //        column = column + 1;
            //    }

            //    Magic[row, column] = Key++; // 在新的位置填上key
            //} //end of for loop
            #endregion Magic Square

            //for (i = 0; i < N; i++)
            //{
            //    for (j = 0; j < N; j++)
            //        Console.Write("{0}", Magic[i, j].ToString().PadLeft(3)); //PadLeft 表給數字與數字之間三個空格
            //    Console.WriteLine();
            //}

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
