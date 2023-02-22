using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.DSA
{
    public class SSList_OOP
    {
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

            public void AddToHead(LNode obj) //將資料加入至list的最前方
            {
                length++;
                if (Head == null)
                    Head = Tail = obj;
                else
                {
                    obj.next = Head;
                    Head = obj;
                } //else
            } //AddToHead

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

            public void Show()
            {
                Console.WriteLine($"Length = {length}");
                LNode ptr = Head;
                while (ptr != null)
                {
                    Console.Write("{0}", ptr.value.ToString().PadLeft(3));
                    ptr = ptr.next;
                }
                Console.WriteLine();
            } //Show

            public void DeleteHead() //刪除Head
            {
                if (Head != null)
                {
                    Head = Head.next;
                    length--;
                } // if
            } // DeleteHead

            public void InsertNode(int index, LNode new_node) //將一個節點加入至ptr節點後面
            {
                int location = 0;
                LNode ptr = Head;
                if (index == location)
                {
                    new_node.next = Head.next;
                    Head = new_node;
                    length++;
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
                            length++;
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

            public void DeleteTail() //刪除最後面一個節點
            {
                LNode ptr = Head;

                if (Tail != null)
                {
                    while (ptr.next != Tail)
                        ptr = ptr.next;

                    Tail = ptr;
                    Tail.next = null;
                    length--;
                    //ptr.next = null;
                    //Tail = ptr;
                } //if 
            } //DeleteTail

            public void Pop() //刪除最後一個
            {
                DeleteTail();
            } //Pop

            public void Pop(int index) //刪除特定位置的節點
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
                            length--;
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

        } //SingleLinked
    }
}
