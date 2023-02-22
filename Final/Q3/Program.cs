using System;

namespace Q3
{
    class Program
    {
        public class Recursive
        {
            public int _n;
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
                else if (n == 2)
                    return 2;
                else
                {
                    if (n % 3 == 0)
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
            Console.WriteLine("110213076 鄭鈺曄");

            Recursive obj = new Recursive(51);
            obj.ShowResult();

            Console.ReadLine();
        }
    }
}
