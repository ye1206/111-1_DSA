using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class SSList_NOOP
    {
        public static LNode Head;
        public static LNode Tail;

        public class LNode
        {
            public int value;
            public LNode next;  //指引下一個值用的
            public LNode(int value) //constructor
            {
                this.value = value; //this 指這個class
            }
        } //LNode

        public static void AddToHead(LNode obj) //將資料加入至list的最前方
        {
            if (Head == null)
                Head = Tail = obj;
            else
            {
                obj.next = Head;
                Head = obj;
            } //else
        } //AddToHead

        public static void Append(LNode obj) //將資料加入List
        {
            if (Tail == null)
                Head = Tail = obj;
            else
            {
                Tail.next = obj; //將一個節點加入至list最後面
                Tail = obj; //將list的結尾指定為新加入的資料
            } //else
        } //Append

        public static void Show()
        {
            LNode ptr = Head;
            while (ptr != null)
            {
                Console.Write("{0}", ptr.value.ToString().PadLeft(3));
                ptr = ptr.next;
            }
            Console.WriteLine();
        } //Show

        public static void DeleteHead() //刪除Head
        {
            if (Head != null)
            {
                Head = Head.next;
            } // if
        } // DeleteHead

        public static void InsertNode(int index, LNode new_node) //將一個節點加入至ptr節點後面
        {
            int location = 0;
            LNode ptr = Head;
            if (index == location)
            {
                new_node.next = Head.next;
                Head = new_node;
            } //if
            else
            {
                ptr = ptr.next;
                location++;
                while (ptr.next != null)
                {
                    if (location == index)
                    {
                        new_node.next = ptr.next;
                        ptr.next = new_node;
                        break;
                    } //inner if
                    else
                    {
                        location++;
                        ptr = ptr.next;
                    } //inner else
                } //while
            } //else
        } //InsertNode

        public static void DeleteTail() //刪除最後面一個節點
        {
            LNode ptr = Head;

            if (Tail != null)
            {
                while (ptr.next != Tail)
                    ptr = ptr.next;

                Tail = ptr;
                Tail.next = null;

                //ptr.next = null;
                //Tail = ptr;
            } //if 
        } //DeleteTail

        //public static void Pop()
        //{
        //    DeleteTail();
        //} //Pop

        public static void Pop(int index) //刪除特定位置的節點
        {
            int location = 0;
            LNode ptr1 = Head;
            LNode ptr2 = Head;

            if (index == 0)
            {
                DeleteHead();
                return;
            } //if
            else
            {
                while (ptr2 != null)
                {
                    if (index == location)
                    {
                        ptr1.next = ptr2.next;
                        break;
                    } //inner if 
                    else
                    {
                        location++;
                        ptr1 = ptr2;
                        ptr2 = ptr2.next;
                    } //inner else
                } //while
            } //else
        } //Pop
    }
}
