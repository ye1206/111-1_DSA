using System;

namespace ObjectOriented
{
    internal class Program
    {
        public class demo
        {
            public int myValue;
            public string myName;
            public demo() //constructor
            {
                myValue = 0;
                myName = "";
            }
            public demo(int v, string n) //constructor
            {
                myValue = v;
                myName = n;
            }

            public void ShowInfo()
            {
                Console.WriteLine("value = {0}, name = {1}", myValue, myName);
            } //ShowInfo

        } //demo

        static void Main(string[] args)
        {
            Random myRandom = new Random();
            int val = myRandom.Next(51);

            demo obj1 = new demo();
            obj1.myValue = 10;
            obj1.myName = "John Lee";
            obj1.ShowInfo();

            Console.Write("------------------------------------------------------------\n");

            demo obj2 = new demo(20, "IM");
            obj2.ShowInfo();

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
