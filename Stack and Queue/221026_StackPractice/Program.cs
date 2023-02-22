using System;

namespace _221026_StackPractice
{
    class Program
    {
        #region global
        public static int top = 0;
        public static int max_size = 10;
        public static string[] myStack = new string[max_size];
        #endregion global

        #region Stack
        public static bool isEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        } //isEmpty

        public static bool isFull()
        {
            if (top == max_size)
                return true;
            else
                return false;
        } //isFull

        public static void Push(string obj)  //如果stack沒有滿則放入東西
        {
            if (!isFull())
            {
                myStack[top] = obj;
                top++;
            }
        } //Push

        public static string Pop()
        {
            if (!isEmpty())
                top--;
            return myStack[top];
        } //Pop
        #endregion Stack


        static void Main(string[] args)
        {
            Push("Peter Lee");
            Push("John Wang");

            Console.WriteLine("{0} is poped...", Pop());
            Console.WriteLine("{0} is poped...", Pop());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
