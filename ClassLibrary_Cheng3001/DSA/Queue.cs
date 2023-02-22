using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class Queue
    {
        #region global
        public static int maxsize = 5;
        public static int front = 0;
        public static int rear = 0;
        public static int[] MyQueue = new int[maxsize];
        public static int obj;
        public static int i;
        #endregion global


        #region Full Or Empty
        public static bool isFull()
        {
            if (rear == maxsize)
                return true;
            else
                return false;
        } //isFull

        public static bool isEmpty()
        {
            if (rear == front)
                return true;
            else
                return false;
        } //isEmpty
        #endregion Full Or Empty

        #region Enqueue and Dequeue
        public static void Enqueue(int number)
        {
            if (!isFull())
            {
                MyQueue[rear] = number;
                rear++;
            } //if
            else
                Console.Write("The queue is full, cannot add any object...\n");
        } //Enqueue
        public static void Dequeue()
        {
            if (!isEmpty())
            {
                obj = MyQueue[front];
                Console.Write("The element {0} is deleted from the queue...\n", obj);
                front++;
            } //if
            else
                Console.Write("The queue is full, {0} cannot be added\n", obj);
        } //Dequeue
        #endregion Enqueue and Dequeue

        public static void Show()
        {
            Console.Write("Queue 現在的內容: ");
            for (i = front; i < rear; i++)
                Console.Write("{0, 3}", MyQueue[i]);
            Console.WriteLine();
        } //Show
    }
}
