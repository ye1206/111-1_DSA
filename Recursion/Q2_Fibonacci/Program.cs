//費氏數列
using System;

namespace Q2_Fibonacci
{
    class Program
    {
        public class Fibon_Recursive01
        {
            int _n;
            int _result;

            public Fibon_Recursive01()
            {
                _n = 1;
                _result = 1;
            } //constructor Fibon_Recursive01

            public Fibon_Recursive01(int a)
            {
                if (a > 0)
                    _n = a;
                else
                    _n = 1;

                _result = 1;
            } //constructor Fibon_Recursive01

            public int Func01(int n)
            {
                if (n == 1)
                    return 1;
                else if (n == 2)
                    return 1;
                else
                    return Func01(n - 1) + Func01(n - 2);
            } //Func01

            public void ShowInfo()
            {
                _result = Func01(_n);
                Console.WriteLine($"F[{_n}] = {_result}\n");
            } //ShowInfo
        } //Fibon_Recursive01
        static void Main(string[] args)
        {
            int i = 0;
            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //Random rnd = new Random(seed);

            for (i = 0; i < 5; i++)
            {
                Fibon_Recursive01 obj = new Fibon_Recursive01(rnd.Next(1, 15));
                obj.ShowInfo();
            } //for

            Console.ReadLine();
        }
    }
}
