// F(m, n) = n + 1, m = 0
// F(m, n) = F(m - 1, 1), n =0
// F(m, n) = F(m - 1, F(m, n - 1)), otherwise
using System;

namespace Q8
{
    class Program
    {
        public class Recursive
        {
            int _m;
            int _n;
            int _result;

            public Recursive()
            {
                _m = _n = _result = 0;
            } //constructor

            public Recursive(int m, int n)
            {
                _m = m;
                _n = n;
                _result = 0;
            } //constructor

            public int RecurFunc(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                else
                {
                    if (n == 0)
                        return RecurFunc(m - 1, 1);
                    else
                        return RecurFunc(m - 1, RecurFunc(m, n - 1));
                } //else
            } //RecurFunc

            public void ShowResult()
            {
                _result = RecurFunc(_m, _n);
                Console.WriteLine("F({0}, {1}) = {2}", _m, _n, _result);
            } //ShowResult
        } //class Recursive
        static void Main(string[] args)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Recursive obj = new Recursive((rnd.Next(1, 4)), (rnd.Next(4, 10)));
                obj.ShowResult();
            } //for

            Console.ReadLine();
        }
    }
}
