using System;
using System.IO;


namespace Q1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region name
            Console.WriteLine("110213076 鄭鈺曄");
            #endregion name

            #region global
            int i = 0, j = 0 ;
            int temp = 0;
            string temp_name = null;
            int min_position;

            #region delimiter and save data to arrays
            StreamReader fileReader;
            char[] delim = { ',', '\t', ';', '\r', ' ' }; //Record delimiter (分隔號)
            fileReader = File.OpenText("input.txt"); //Open file //測資在bin\debug\netcore3.11裡
            string inputdataS = fileReader.ReadToEnd();
            string[] inputField = inputdataS.Split(delim);
            int SIZE = inputField.Length; //應該可以直接縮成inputField.Length / 3

            int[] weight = new int[SIZE / 3 -1]; //理論上應該可以縮成SIZE - 1
            int[] IQ = new int[SIZE / 3 - 1];
            int[] attractive = new int[SIZE / 3 - 1];
            string[] name = new string[SIZE / 3 - 1];
            for (i = 0; i < name.Length; i++)
            {
                name[i] = inputField[3 * (i +1)];
                weight[i] = int.Parse(inputField[3 * (i + 1) + 1]);
                IQ[i] = int.Parse(inputField[3 * (i +1) + 2]);
                attractive[i] = (8 - weight[i]) + (8 - IQ[i]);
            }// for
            #endregion delimiter and save data to arrays

            attractive[1] = 0;

            string[] data = new string[name.Length];
            #endregion global

            #region AB
            Console.Write("狗狗名稱\t體重排行\t智商排行\t魅力值\n");
            for (i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]}\t{weight[i]}\t{IQ[i]}\t{ attractive[i]}\n");
            }// for
            #endregion AB

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            #region Bubble Sort
            Console.WriteLine("體重排序原始陣列內容:");
            for (i = 0; i < name.Length; i++)
                Console.Write($"{name[i]}{weight[i]}    ");
            Console.WriteLine();
            //Sorting.BubbleSort(weight);
            for (i = 0; i < name.Length; i++) //Bubble sorting
            {
                Console.Write($"第 {i + 1} 回合排序後體重排序:");
                for (j = 0; j < name.Length - 1; j++)
                {
                    while (weight[j] > weight[j + 1])
                    {
                        temp = weight[j];
                        temp_name = name[j];
                        weight[j] = weight[j + 1];
                        name[j] = name[j + 1];
                        weight[j + 1] = temp;
                        name[j + 1] = temp_name;
                        data[j] = name[j] + weight[j].ToString();
                        data[j + 1] = name[j + 1] + weight[j + 1].ToString();
                    } //while
                    
                    //Console.Write($"{name[j]}" + $"{weight[j]}");     //少一個element              
                } //for
                foreach (string var in data)
                    Console.Write(var);
                Console.WriteLine();
            } // end of outer loop

            Console.WriteLine();
            #endregion Bubble Sort

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            #region Selection Sort
            Console.WriteLine("智商排序原始陣列內容:");
            for (i = 0; i < name.Length; i++)
                Console.Write($"{name[i]}{IQ[i]}    ");
            Console.WriteLine();

            for (i = 0; i < name.Length - 1; i++)
            {
                min_position = i;
                for (j = i + 1; j < name.Length; j++)
                {
                    if (IQ[j] < IQ[min_position])  //如果發現[j]的數字比[min_position]的數字小，就將j取代min_position 
                        min_position = j;  //remember the position
                } // inner loop

                temp = IQ[i];
                temp_name = name[i];
                IQ[i] = IQ[min_position];
                name[i] = name[min_position];
                IQ[min_position] = temp;   // 25-27行即完成一回合的交換
                name[min_position] = temp_name;

                Console.Write($"第{i + 1}回合排序結果\t");

                for (j = 0; j < name.Length; j++)
                    Console.Write($"{name[j]}{IQ[j].ToString().PadLeft(4)}");
                Console.WriteLine("\n");
            } //outer loop
            #endregion Selection Sort

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            #region Insertion Sort
            Console.Write("魅力值排序原始陣列內容:");
            for (i = 0; i < name.Length; i++)
                Console.Write($"{name[i]}{attractive[i]}    ");
            Console.WriteLine();

            for (i = 1; i < name.Length; i++)
            {
                Console.Write($"第{i}回合排序: \n");
                temp = attractive[i];
                temp_name = name[i];

                for (j = i - 1; j >= 0; j--)
                {
                    if (attractive[j] > temp)
                    {
                        attractive[j + 1] = attractive[j];
                        name[j + 1] = name[j];

                        if (j == 0)
                        {
                            attractive[j] = temp;
                            name[j] = temp_name;
                        }
                    }
                    else
                    {
                        attractive[j + 1] = temp;
                        name[j + 1] = temp_name;
                        break;
                    }
                } // inner loop

                //Console.Write($"{name[i]}{attractive[i]}  ");
                for (j = 0; j < name.Length; j++)
                {
                    Console.Write(name[j] + attractive[j] + "\n");
                }


                //foreach (int var in attractive)
                //Console.Write(var.ToString().PadLeft(4));
                Console.WriteLine();

            } // outer loop
            #endregion Insertion Sort

            Console.ReadLine();
        }
    }
}
