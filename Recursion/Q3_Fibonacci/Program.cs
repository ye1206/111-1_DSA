// sum(n) = n + (n - 1) + ... + 1
using System;

namespace Q3_Fibonacci
{
    class Program
    {
        public class Fibon_Recursive02
        {
            int _n;
            int _result;

            public Fibon_Recursive02()
            {
                _n = 1;
                _result = 1;
            } //constructor Fibon_Recursive01

            public Fibon_Recursive02(int a)
            {
                if (a > 0)
                    _n = a;
                else
                    _n = 1;

                _result = 1;
            } //constructor Fibon_Recursive01

            public int Func02(int n)
            {
                if (n == 1)
                    return 1;
                else
                    return n + Func02(n - 1);
            } //Func01

            public void ShowInfo()
            {
                _result = Func02(_n);
                Console.WriteLine($"F[{_n}] = {_result}\n");
            } //ShowInfo
        } //Fibon_Recursive02

        static void Main(string[] args)
        {
            int i = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (i = 0; i < 5; i++)
            {
                Fibon_Recursive02 obj = new Fibon_Recursive02(rnd.Next(1, 15));
                obj.ShowInfo();
            } //for
            
        }
    }
}
