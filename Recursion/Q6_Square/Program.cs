// a的b次方
using System;

namespace Q6_Square
{
    public class Program
    {
        public class Power
        {
            int _a, _b, _result;

            public Power()
            {
                _a = _b = _result = 0;
            } //constructor

            public Power(int a, int b)
            {
                _a = 0;
                if (a >= 0)
                    _a = a;

                _b = 0;
                if (b >= 0)
                    _b = b;

                _result = 0;
            } //constructor

            public int PowerFunc(int A, int B)
            {
                if (B == 0)
                    return 1;
                else if (B == 1)
                    return A;
                else
                    return A * PowerFunc(A, B - 1);
            } //PowerFunc

            public void ShowResult()
            {
                _result = PowerFunc(_a, _b);
                Console.WriteLine($"Power({_a}, {_b}) = {_result}");
            } //ShowResult
        } //class Power

        static void Main(string[] args)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Power obj = new Power((rnd.Next(2, 6)), (rnd.Next(3, 8)));
                obj.ShowResult();
            } //for

            Console.ReadLine();
        }
    }
}
