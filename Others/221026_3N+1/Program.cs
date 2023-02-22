using System;

namespace _221026_3N_1
{
    class Program
    {
        public class ThreeNPlusOne
        {
            #region global
            private int _n;
            private int _count; //靜態屬性
            public int N
            {
                set
                {
                    if (value >= 0)
                        _n = value;
                    else
                        _n = 1;
                } //set
                get 
                {
                    return _n;
                } //get
            } //N

            public int Count{ get{return _count;}} //Count
            #endregion global

            public ThreeNPlusOne()
            {
                _n = 1;
                _count = 0;
            } //default constructor

            public ThreeNPlusOne(int _n)
            {
                this._n = _n;
            } //constructor

            public void Compute()
            {
                _count = 0;
                int num = _n;
                while ((num != 1) && (_count < 500))
                {
                    _count++;

                    if (num % 2 == 1)
                        num = num * 3 + 1;
                    else
                        num = num / 2;
                }
            } //Compute

            public void DisplayInfo()
            {
                Console.WriteLine("{0} do {1} times", _n.ToString(), _count.ToString());
            } //DisplayInfo
        }   //Class ThreeNPlusOne

        public static void BubbleSort(ThreeNPlusOne[] data)
        {
            int i = 0, j = 0;
            ThreeNPlusOne temp = new ThreeNPlusOne();

            for (i = 0; i < data.Length; i++)
            {
                for (j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j].Count < data[j + 1].Count)
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    } //if
                    else if (data[j].Count == data[j + 1].Count)
                    {
                            if (data[j].N < data[j + 1].N)
                            {
                                temp = data[j];
                                data[j] = data[j + 1];
                                data[j + 1] = temp;
                            } //data[j].N < data[j + 1].N
                    } //else if data[j].Count == data[j + 1].Count
                } //inner for loop
            } //outer for loop
        } //BubbleSort
        static void Main(string[] args)
        {
            int Num;
            int temp;
            int i = 0;

            #region Constructor
            Console.Write("Constructor\n");
            Console.Write("Please input two positive integers: ");
            int[] num = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            if (num[0] > num[1])
            {
                temp = num[0];
                num[0] = num[1];
                num[1] = temp;
            } //if

            int total = num[1] + num[0] + 1;
            ThreeNPlusOne[] data = new ThreeNPlusOne[total]; //宣告array

            for (i = num[0]; i <= num[1]; i++)
            {
                data[i - num[0]] = new ThreeNPlusOne();
                data[i - num[0]].N = i; //call N (above)
                data[i - num[0]].Compute();
                data[i - num[0]].DisplayInfo();
            } //for loop

            
            Console.Write("****After Sort****");
            BubbleSort(data); //call by reference
            for (i = 0; i < data.Length; i++)
                data[i].DisplayInfo();
            

            //Num = int.Parse(Console.ReadLine());
            //ThreeNPlusOne obj = new ThreeNPlusOne(Num);

            //obj.Compute();
            //obj.DisplayInfo();
            #endregion Constructor

            Console.WriteLine();

            #region Set And Get
            //Console.Write("Set and get\n");
            //ThreeNPlusOne obj_2 = new ThreeNPlusOne();
            //obj_2.N = 14;
            //obj_2.Compute();
            //obj_2.DisplayInfo();
            #endregion Set And Get

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
