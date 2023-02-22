using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class Stack
    {
        #region global
        public static int top = 0;
        public static int max_size = 10;
        public static string[] MyStack = new string[max_size];
        #endregion global

        #region Empty Or Full
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
        #endregion Empty Or Full

        #region Push and Pop

        public static void Push(string obj)
        {
            if (!isFull())
            {
                MyStack[top] = obj;
                top++;
            } //if
        } //Push

        public static string Pop()
        {
            if (!isEmpty())
            {
                top--;
                return MyStack[top];
            }
            else
                return null;

        } //Push
        #endregion Push and Pop
    }
}
