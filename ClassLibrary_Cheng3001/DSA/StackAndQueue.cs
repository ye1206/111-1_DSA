using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class StackAndQueue
    {
        #region global
        public static int top = 0;
        public static int max_size;
        //public static string[] MyStack = new string[max_size];

        //public static int maxsize = 5;
        public static int front = 0;
        public static int rear = 0;
        //public static int[] MyQueue = new int[maxsize];
        public static int obj;
        public static int i;
        #endregion global

        #region Full Or Empty
        public static bool isStackEmpty(bool isStack)
        {
            if (true) //須處理的資料為堆疊(Stack)
            {
                if (top == 0)
                {
                    //Console.WriteLine("The stack is empty now");
                    return true;
                } //if 
                else
                {
                    //Console.WriteLine("Now we have something in the stack.");
                    return false;
                } //else
            } //if
            else //須處理的資料為佇列(Queue)
            {
                if (rear == front)
                    return true;
                else
                    return false;
            } //else
        } //isStackEmpty

        public static bool isStackFull(bool isStack, int maxsize)
        {
            if (true) //須處理的資料為堆疊(Stack)
            {
                if (top == maxsize)
                    return true;
                else
                    return false;
            } //for stack
            else //須處理的資料為佇列(Queue)
            {
                if (rear == maxsize)
                    return true;
                else
                    return false;
            } //else 
        } //isStackFull

        #endregion Full Or Empty

        #region Push and Pop for Stack
        public static void Push(string obj, string[] MyStack, int maxsize)
        {
            if (!isStackFull(true, maxsize))
            {
                MyStack[top] = obj;
                //Console.WriteLine($"{ MyStack[top]} is pushed\n");
                top++;
            } //if
        } //Push

        public static string Pop(string[] MyStack)
        {
            if (!isStackEmpty(true))
            {
                top--;
                Console.Write($"{ MyStack[top]} is poped\n");
                return MyStack[top];
            }
            else
                return null;
        } //Push
        #endregion Push and Pop for Stack

        #region Enqueue and Dequeue for Queue
        public static void Enqueue(int number, int[] MyQueue, int maxsize)
        {
            if (!isStackFull(false, maxsize))
            {
                MyQueue[rear] = number;
                Console.WriteLine($"{ MyQueue[rear]} is enqueued\n");
                rear++;
            } //if
            else //isStackFull(false, maxsize) == true
                Console.Write("The queue is full, cannot add any object...\n");
        } //Enqueue //Need to fix

        public static void Dequeue(int[] MyQueue, int maxsize)
        {
            if (!isStackEmpty(false))
            {
                //obj = MyQueue[front];
                Console.Write("The element {0} is deleted from the queue...\n", MyQueue[front]);
                front++;
            } //if
            else
                Console.Write("The queue is empty, {0} cannot be deleted\n", obj);
        } //Dequeue
        #endregion Enqueue and Dequeue for Queue

        #region Show Data
        public static void StackShow(string[] MyStack)
        {
            Console.Write("Stack 現在的內容: ");
            for (i = 0; i < top; i++)
                Console.Write(MyStack[i] + "    ");
            Console.WriteLine();
        } //StackShow

        public static void QueueShow(int[] MyQueue)
        {
            Console.Write("Queue 現在的內容: ");
            for (i = front; i < rear; i++)
                Console.Write("{0, 3}", MyQueue[i]);
            Console.WriteLine();
        } //QueueShow
        #endregion Show Data
    }
}
