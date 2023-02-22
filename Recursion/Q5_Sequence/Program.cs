// 等差級數 Sum of a + (a + b) + .. + (a + (N - 1)b)
using System;

namespace Q5_Sequence
{
        class Program
        {
            public class Arithmetic
            {
                int _a, _b, _n;
                int _result;
                public Arithmetic()
                {
                    _a = _b = _n = _result = 0;
                } //consturctor

                public Arithmetic(int a, int b, int N)
                {
                    _a = a;
                    _b = b;
                    _n = N;
                } //constructor

                public int ArithmeticFunc(int a, int b, int N)
                {
                    if (N == 1)
                        return a;
                    else
                        return ArithmeticFunc(a, b, N - 1) + (a + (N - 1) * b);
                } //ArithmeticFunc

                public void ShowInfo()
                {
                    _result = ArithmeticFunc(_a, _b, _n);
                    Console.WriteLine($"F({_a}, {_b}, {_n}) = {_result}");
                } //ShowInfo
            } //class Arithmetic 

            static void Main(string[] args)
            {
                int seed = (int)DateTime.Now.Ticks & 0x0000FFFF;
                Random rnd = new Random();
                int i = 0;

                for (i = 0; i < 5; i++)
                {
                    Arithmetic obj = new Arithmetic((rnd.Next(3, 10)), (rnd.Next(2, 10)), (rnd.Next(3, 11)));
                    obj.ShowInfo();
                } //for

                Console.ReadLine();

            }
        }
    }

