using System;

namespace Q2
{
    class Program
    {
        public class Stack
        {
            public int MaxSize;
            public string[] MyStack;
            public int top;

            public Stack() //default
            {
                MaxSize = 0;
                top = 0;
                MyStack = null;
            } //constructor

            public Stack(int val) //overload
            {
                MaxSize = val;
                MyStack = new string[MaxSize];
                top = 0;
            } //constructor

            #region Empty or Full
            public bool isEmpty()
            {
                if (top == 0)
                    return true;
                else
                    return false;
            } //isEmpty

            public bool isFull()
            {
                if (top == MaxSize)
                    return true;
                else
                    return false;
            } //isFull
            #endregion Empty or Full

            #region Push and Pop
            public string Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("The stack is empty");
                    return "";
                } //if
                else
                {
                    top--;
                    Console.WriteLine($"\n{MyStack[top]} is poped, top = {top}");
                    return MyStack[top];
                } //else
            } //Pop

            public void Push(string obj)
            {
                if (isFull())
                    Console.WriteLine("Stack is full, cannot be pushed...");
                else
                {
                    MyStack[top] = obj;
                    top++;
                    Console.WriteLine($"{obj} is added into the stack, top = {top}");
                } //else
            } //Push
            #endregion Push and Pop

            public void ShowInfo()
            {
                Console.WriteLine($"\nPrint Current Stack, top = {top}");

                if (!isEmpty())
                {
                    int i = 0;
                    for (i = top - 1; i >= 0; i--)
                        Console.WriteLine(MyStack[i]);
                    Console.WriteLine();
                } //if
                else
                    Console.WriteLine("Stack has nothing to show...");
            } //ShowInfo
        } //Stack
        static void Main(string[] args)
        {
            #region name
            Console.WriteLine("110213076 鄭鈺曄");
            #endregion name

            Stack mystack = new Stack(8);
            Console.Write("Please input the instruction: ");
            string x = Console.ReadLine();
            string[] command = x.Split(' ');
            int i = 0;

            for (i = 0; i < command.Length; i++)
            {
                if (command[i] == "1")
                    mystack.Push(command[i + 1]);
                else if (command[i] == "2")
                    mystack.Pop();
                else if (command[i] == "3")
                    mystack.ShowInfo();
            } //for
            Console.ReadLine();
        }
    }
}
