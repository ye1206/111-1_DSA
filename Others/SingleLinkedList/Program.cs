using ClassLibrary_Cheng3001.DSA;
using System;
//using ClassLibrary_Cheng3001.DSA ;
using static ClassLibrary_Cheng3001.DSA.SSList_OOP;

namespace SingleLinkedList
{
    class Program 
    {
        #region non object-oriented
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
        #endregion non object-oriented

        #region object-oriented
        //public class LNode
        //{
        //    public int value;
        //    public LNode next;
        //    public LNode(int value)
        //    {
        //        this.value = value;
        //        next = null;
        //    } //constructor
        //} //LNode

        //public class SingleLinked
        //{
        //    public LNode Head;
        //    public LNode Tail;
        //    public int length;

        //    public SingleLinked()
        //    {
        //        Head = Tail = null;
        //        length = 0;
        //    } //default constructor

        //    public void AddToHead(LNode obj) //將資料加入至list的最前方
        //    {
        //        length++;
        //        if (Head == null)
        //            Head = Tail = obj;
        //        else
        //        {
        //            obj.next = Head;
        //            Head = obj;
        //        } //else
        //    } //AddToHead

        //    public void Append(LNode obj) //將資料加入List
        //    {
        //        length++;
        //        if (Tail == null)
        //            Head = Tail = obj;
        //        else
        //        {
        //            Tail.next = obj; //將一個節點加入至list最後面
        //            Tail = obj; //將list的結尾指定為新加入的資料
        //        } //else
        //    } //Append

        //    public void Show()
        //    {
        //        Console.WriteLine($"Length = {length}");
        //        LNode ptr = Head;
        //        while (ptr != null)
        //        {
        //            Console.Write("{0}", ptr.value.ToString().PadLeft(3));
        //            ptr = ptr.next;
        //        }
        //        Console.WriteLine();
        //    } //Show

        //    public void DeleteHead() //刪除Head
        //    {
        //        if (Head != null)
        //        {
        //            Head = Head.next;
        //            length--;
        //        } // if
        //    } // DeleteHead

        //    public void InsertNode(int index, LNode new_node) //將一個節點加入至ptr節點後面
        //    {
        //        int location = 0;
        //        LNode ptr = Head;
        //        if (index == location)
        //        {
        //            new_node.next = Head.next;
        //            Head = new_node;
        //            length++;
        //        } //if
        //        else
        //        {
        //            ptr = ptr.next;
        //            location++;
        //            while (ptr.next != null)
        //            {
        //                if (location == index)
        //                {
        //                    new_node.next = ptr.next;
        //                    ptr.next = new_node;
        //                    length++;
        //                    break;
        //                } //inner if
        //                else
        //                {
        //                    location++;
        //                    ptr = ptr.next;
        //                } //inner else
        //            } //while
        //        } //else
        //    } //InsertNode

        //    public void DeleteTail() //刪除最後面一個節點
        //    {
        //        LNode ptr = Head;

        //        if (Tail != null)
        //        {
        //            while (ptr.next != Tail)
        //                ptr = ptr.next;

        //            Tail = ptr;
        //            Tail.next = null;
        //            length--;
        //            //ptr.next = null;
        //            //Tail = ptr;
        //        } //if 
        //    } //DeleteTail

        //    public void Pop() //刪除最後一個
        //    {
        //        DeleteTail();
        //    } //Pop

        //    public void Pop(int index) //刪除特定位置的節點
        //    {
        //        int location = 0;
        //        LNode ptr1 = Head;
        //        LNode ptr2 = Head;

        //        if (index == 0)
        //        {
        //            DeleteHead();
        //            return;
        //        } //if
        //        else
        //        {
        //            while (ptr2 != null)
        //            {
        //                if (index == location)
        //                {
        //                    ptr1.next = ptr2.next;
        //                    length--;
        //                    break;

        //                } //inner if 
        //                else
        //                {
        //                    location++;
        //                    ptr1 = ptr2;
        //                    ptr2 = ptr2.next;
        //                } //inner else
        //            } //while
        //        } //else
        //    } //Pop

        //} //SingleLinked
        #endregion object-oriented

        static void Main(string[] args)
        {
            //SSList_NOOP.Head = SSList_NOOP.Tail = null;
            //Head = Tail = null;

            //SSList_NOOP.LNode obj1 = new SSList_NOOP.LNode(10);
            ////LNode obj1 = new LNode(10);
            //LNode obj2 = new LNode(20);
            //LNode obj3 = new LNode(30);

            //SSList_NOOP.Append(obj1);
            //// Append(obj1); 
            ////Append(obj2); 
            ////Append(obj3);

            //SSList_NOOP.Show();
            //Show();
            //LNode obj4 = new LNode(-10);
            //AddToHead(obj4);
            //Show();
            //DeleteHead(); Show();
            //LNode obj5 = new LNode(25);
            //InsertNode(1, obj5); //2 index 
            //Show();

            //DeleteTail(); Show();
            //Pop(2);
            //Show();

            // SingleLinked mylist01 = new SingleLinked();

            // LNode obj1 = new LNode(10);
            // LNode obj2 = new LNode(20);
            // LNode obj3 = new LNode(30);

            //mylist01. Append(obj1);
            // mylist01.Append(obj2);
            // mylist01.Append(obj3);
            // Console.Write("Add data to List\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // LNode obj4 = new LNode(-10);
            // mylist01.AddToHead(obj4);
            // Console.Write("Add data to the front of List\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // mylist01.DeleteHead();
            // Console.Write("Delete data from the front of List\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // LNode obj5 = new LNode(25);
            // mylist01.InsertNode(1, obj5);
            // Console.Write("Add data to specific index of list\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // mylist01.DeleteTail();
            // Console.Write("Delete data of the last  one in List\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // mylist01.Pop(2);
            // Console.Write("Delete data to specific index of list\n");
            // mylist01.Show();
            // Console.Write("--------------------------------------------------------------------------\n");

            // Console.WriteLine("Show the second single linked list");
            // SingleLinked mylist02 = new SingleLinked();
            // int i = 0;
            // Random rnd = new Random(Guid.NewGuid().GetHashCode());

            // for (i = 0; i < 5; i++)
            // {
            //     LNode new_node = new LNode(rnd.Next(-10, 101));
            //     mylist02.Append(new_node);
            // } //for
            // mylist02.Show();

            SingleLinked try1 = new SingleLinked();
            int i = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (i = 0; i < 5; i++)
            {
                SSList_OOP.LNode new_node = new SSList_OOP.LNode(rnd.Next(-10, 101));
                try1.Append(new_node);
            } //for
            try1.Show();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
