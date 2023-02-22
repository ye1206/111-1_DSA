using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz4WithOOP
{
    public class OOPQueue
    {
        #region global
        public int MaxSize;
        public int Front;
        public int Rear;
        public int HowMany;
        public int[] CircularQueue;
        public int[] pickup;
        #endregion global

        public OOPQueue(int maxsize)
        {
            this.MaxSize = maxsize + 1;
            HowMany = 0;
            CircularQueue = new int[MaxSize];
            pickup = new int[maxsize];
        } //OOPQueue (constructor)

        #region Full or Empty
        public bool isEmpty()
        {
            if (Front == Rear)
                return true;
            else
                return false;
        } //isEmpty

        public bool isFull()
        {
            if (((Rear + 1) % MaxSize) == Front)
                return true;
            else
                return false;
        } //isFull
        #endregion Full or Empty

        #region Enqueue and Dequeue
        public void Enqueue(int num)
        {
            if (!isFull())
            {
                CircularQueue[Rear] = num;
                Rear = (Rear + 1) % MaxSize;
            } //if
            // Console.WriteLine("Queue is full, {0} cannot be enqueued.", num);
        } //Enqueue

        public void Dequeue(ref int val)
        {
            if (!isEmpty())
            {
                val = CircularQueue[Front];
                // Console.WriteLine("{0} is removed from queue", CircularQueue[Front]);
                Front = (Front + 1) % MaxSize;
            } //if
        } //Dequeue
        #endregion Enqueue and Dequeue

        public void Process()
        {
            #region global
            int i = 0;
            int value = 0;
            #endregion global

            for (i = 1; i <= MaxSize; i++)
                Enqueue(i);

            while (!isEmpty())
            {
                Dequeue(ref value);
                pickup[HowMany] = value;
                HowMany++;

                if (isEmpty())
                    break;
                else
                {
                    Dequeue(ref value);
                    Enqueue(value);
                } //else
            } //while
        } //Process

        public void ShowAnswer()
        {
            int i = 0;
            for (i = 0; i < HowMany; i++)
                Console.Write("{0}", pickup[i].ToString().PadLeft(3));
            Console.WriteLine();
        } //ShowAnswer
    } //OOPQueue
} //Quiz$WithOOP
    