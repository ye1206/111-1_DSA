using System;
using System.Collections.Immutable;

namespace Q1
{
    class Program
    {
        #region SingleLinkedList
        public class LNode
        {
            public int value;
            public LNode next;
            public LNode(int value)
            {
                this.value = value;
                next = null;
            } //constructor
        } //LNode

        public class SingleLinked
        {
            public LNode Head;
            public LNode Tail;
            public int length;

            public SingleLinked()
            {
                Head = Tail = null;
                length = 0;
            } //default constructor

            public void Append(LNode obj) //將資料加入List
            {
                length++;
                if (Tail == null)
                    Head = Tail = obj;
                else
                {
                    Tail.next = obj; //將一個節點加入至list最後面
                    Tail = obj; //將list的結尾指定為新加入的資料
                } //else
            } //Append

            public void PrintList()
            {
                Console.Write($"長度 = {length}, ");
                LNode ptr = Head;
                Console.Write("內容: ");
                while (ptr != null)
                {
                    Console.Write("{0}", ptr.value.ToString().PadLeft(3));
                    ptr = ptr.next;
                }
                Console.WriteLine();
            } //PrintList


            public void Sort(int[] data)
            {
                int i = 0, j = 0;
                int min_position = 0;
                int temp = 0;

                Console.Write($"長度: {data.Length}, 內容: ");

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
                    data[min_position] = temp;   
                } //outer loop

                foreach (int obj in data)
                    Console.Write(obj + " ");
            } //Sort
        } //SingleLinked
            #endregion SingleLinkedList

            static void Main(string[] args)
            {
                Console.WriteLine("110213076 鄭鈺曄\n");

                SingleLinked data = new SingleLinked();
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                int i = 0;
                int[] s = new int[5];

                for(i = 0; i < 5; i++)
                {
                    LNode new_node = new LNode(rnd.Next(-50, 100));
                    data.Append(new_node);
                    s[i] = new_node.value;
                } //for

                Console.WriteLine("排序前資料");
                data.PrintList();

                Console.WriteLine("排序後資料");
                data.Sort(s);               

                Console.ReadLine();
            }
        }
    }

