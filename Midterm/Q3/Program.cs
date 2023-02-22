using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region name
            Console.WriteLine("110213076 鄭鈺曄");
            #endregion name

            #region global
            int[] size = new int[] { 3, 5, 7, 9};
            Random rnd = new Random();
            int index = rnd.Next(0, 4);
            Console.WriteLine($"魔方陣大小為 {size[index]}");
            int i = 0, j = 0;
            int[,] Magic = new int[size[index], size[index]];  // 宣告方陣
            int n = size[index] - 1;
            int row = 0, column = (size[index] - 1) / 2; // 取得最中間的格數
            int Key = 1; //key 表填入的數字，以1為首個數字
            string[,] output = new string[size[index], size[index]];
            #endregion global

            #region Magic Square
             for (i = 0; i < size[index]; i++)    // 初始化方陣
                for (j = 0; j < size[index]; j++)
                        Magic[i, j] = 0;

                Magic[row, column] = Key++;

                for (i = Key; i <= size[index] * size[index]; i++) //開始運作
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

            #region output
            for (i = 0; i < size[index]; i++)
            {
                for (j = 0; j < size[index]; j++)
                {
                    if (Magic[i, j] < 10)
                        output[i, j] = "0" + Magic[i, j].ToString();
                    else
                        output[i, j] = Magic[i, j].ToString();
                        
                    Console.Write("{0}", output[i , j].PadLeft(3)); //PadLeft 表給數字與數字之間三個空格
                }
                Console.WriteLine();
                } //for
            #endregion output


            Console.ReadLine();
        }
    }
}
