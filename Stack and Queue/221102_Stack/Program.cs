using System;
using ClassLibrary_Cheng3001.DSA;

namespace _1102_Stack
{
    class Program
    {
        //    #region global
        //    public static int top = 0;
        //    public static int max_size = 10;
        //    public static string[] MyStack = new string[max_size];
        //    #endregion global

        //    #region Stack
        //    public static bool isEmpty()
        //    {
        //        if (top == 0)
        //            return true;
        //        else
        //            return false;
        //    } //isEmpty

        //    public static bool isFull()
        //    {
        //        if (top == max_size)
        //            return true;
        //        else
        //            return false;
        //    } //isFull

        //    public static void Push(string obj)
        //    {
        //        if (!isFull())
        //        {
        //            MyStack[top] = obj;
        //            top++;
        //        } //if
        //    } //Push

        //    public static string Pop()
        //    {
        //        if (!isEmpty())
        //        {
        //            top--;
        //            return MyStack[top];
        //        }
        //        else
        //            return null;

        //    } //Push
        //    #endregion Stack

        static void Main(string[] args)
        {
            int maxsize = 10;
            string[] myStack = new string[maxsize];

            StackAndQueue.isStackEmpty(true);
            StackAndQueue.isStackFull(true, maxsize);

            StackAndQueue.Push("Peter Lee", myStack, maxsize);
            StackAndQueue.Push("John Wang", myStack, maxsize);

            StackAndQueue.StackShow(myStack);

            StackAndQueue.Pop(myStack);
            StackAndQueue.Pop(myStack);


            Console.ReadKey();
        }
    }
}
