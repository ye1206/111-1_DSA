//F(0) = 0, F(1) = 1
//F(2n) = 2 * F(n) - 1, n > 1
//F(2n + 1) = 2* F(n) + 1, n > 0
using System;

namespace Q7
{
    public class Program
    {
        public class Recursive
        {
            private int _n;
            private int _result;
            public Recursive()
            {
                _n = 0;
                _result = 0;
            } //constructor

            public Recursive(int a)
            {
                _n = a;
                _result = 0;
            } //constructor

            public int RecurFunc(int n)
            {
                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                {
                    if (n % 2 == 0)
                        return (3 * RecurFunc(n) - 1);
                    else if (n % 3 == 1)
                        return (3 * RecurFunc(n));
                    else
                        return (3 * RecurFunc(n) + 1);
                } //else
            } //RecurFunc

            public void ShowResult()
            {
                _result = RecurFunc(_n);
                Console.WriteLine($"n = {_n}, ans = {_result}\n");
            } //ShowResult
        } //class Recursive
        static void Main(string[] args)
        {
            Recursive r = new Recursive(51);
            r.ShowResult();
            Console.ReadLine();
            //int i = 0;
            //Random rnd = new Random(Guid.NewGuid().GetHashCode());

            //for (i = 0; i < 5; i++)
            //{
            //    Recursive obj = new Recursive(rnd.Next(1, 21));
            //    obj.ShowResult();
            //} //for

            Console.ReadLine();
        }
    }
}
