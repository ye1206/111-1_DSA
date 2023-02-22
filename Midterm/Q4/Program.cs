using System;

namespace Q4
{
    class Program
    {
        
        #region global
        public static int maxsize;
        public static int front = 0;
        public static int rear = 0;
        public static int[] MyQueue = new int[maxsize];
        public static int obj;
        public static int i;
        #endregion global


        #region Full Or Empty
        public static bool isFull(int maxsize)
        {
            if (rear == maxsize)
                return true;
            else
                return false;
        } //isFull

        public static bool isEmpty(int maxsize)
        {
            if (rear == front)
                return true;
            else
                return false;
        } //isEmpty
        #endregion Full Or Empty

        #region Enqueue and Dequeue
        public static void Enqueue(int number, int maxsize)
        {
            if (!isFull(maxsize))
            {
                MyQueue[rear] = number;
                rear++;
            } //if
            else
                Console.Write("The queue is full, cannot add any object...\n");
        } //Enqueue
        public static void Dequeue(int maxsize)
        {
            if (!isEmpty(maxsize))
            {
                obj = MyQueue[front];
                Console.Write("The element {0} is deleted from the queue...\n", obj);
                front++;
            } //if
            else
                Console.Write("The queue is full, {0} cannot be added\n", obj);
        } //Dequeue
        #endregion Enqueue and Dequeue
        static void Main(string[] args)
        {
            #region name
            Console.WriteLine("110213076 鄭鈺曄");
            #endregion name

            #region global
            int i = 0, j = 0;
            int[] num = new int[4];
            for (i = 0; i < 4; i++)
            {
                Console.Write("請輸入五個數字: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            int[] card1 = new int[num[0]];
            int[] card2 = new int[num[1]];
            int[] card3 = new int[num[2]];
            int[] card4 = new int[num[3]];
            int[] card5 = new int[num[4]];
            int keyNum = 1;


            #endregion global

        }
    }
}
