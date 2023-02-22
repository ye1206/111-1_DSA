using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class MagicMatrix
    {
        public static void Square(int num)
        {
            #region global
            int i = 0, j = 0;
            Console.WriteLine($"\n N = {num} 的魔術方陣\n");
            int[,] Magic = new int[num, num];  // 宣告方陣
            int n = num - 1;
            int row = 0, column = (num - 1) / 2; // 取得最中間的格數
            int Key = 1; //key 表填入的數字，以1為首個數字
            #endregion global

            #region Magic Square
            for (i = 0; i < num; i++)    // 初始化方陣
                for (j = 0; j < num; j++)
                    Magic[i, j] = 0;

            Magic[row, column] = Key++;

            for (i = Key; i <= num * num; i++) //開始運作
            {
                row = row - 1; //計算下個數值的位置
                column = column - 1; // 計算下個數值的位置

                if ((row < 0) && (column >= 0))
                    row = n;
                else
                {
                    if ((row >= 0) && (column < 0))
                        column = n;
                    else  //((row < 0) && (column < 0))
                    {
                        if ((row < 0) && (column < 0))
                        {
                            row = row + 2;
                            column = column + 1;
                        }
                    } // inner else
                } //outer else

                if (Magic[row, column] != 0) //檢驗格子內是否有填數字
                {
                    row = row + 2;
                    column = column + 1;
                }

                Magic[row, column] = Key++; // 在新的位置填上key
            } //end of for loop
            #endregion Magic Square

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < num; j++)
                    Console.Write("{0}", Magic[i, j].ToString().PadLeft(3)); //PadLeft 表給數字與數字之間三個空格
                Console.WriteLine();
            } //for
        } //Magic
    }
}
