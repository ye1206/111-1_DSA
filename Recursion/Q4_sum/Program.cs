// 1 * 2 + 2 * 3 + ... + (n - 1) * n 
using System;

namespace Q4_sum
{
    class Program
    {
        public class Sum_Func
        {
            private int _n;
            private int _result;
            public Sum_Func()
            {
                _n = 0;
                _result = 0;
            } //constructor

            public Sum_Func(int a)
            {
                if (a >= 0)
                    _n = a;
                else
                    _n = 1;

                _result = 0;
            } //constructor

            public int Sum(int n)
            {
                if (n == 1)
                    return 0;
                else
                    return Sum(n - 1) + (n - 1) * n;
            } //Sum

            public void ShowResult()
            {
                _result = Sum(_n);
                Console.WriteLine($"F({_n}) = {_result}");
            } //ShowResult

        } //Sum_Func


    static void Main(string[] args)
        {
            int result = 0;
            //result = Sum(4);
            //Console.WriteLine($"F({4}) = {result}");
            int i = 0;
            //int time = 0;

            for (i = 0; i < 10; i++)
            {
                Sum_Func obj = new Sum_Func(i);
                obj.ShowResult();
                // time++;
                //Console.WriteLine($"time = {time}");
            } //for

            Console.ReadLine();
        }
    }
}
