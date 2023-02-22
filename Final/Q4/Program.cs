using System;

namespace Q4
{
    class Program
    {
        public class RecursiveDemo
        {
            int _n;
            int _result;
            public int GetValue()
            {
                return _n;
            } //GetValue

            public RecursiveDemo()
            {
                _n = 0;
                _result = 1;
            } //constructor RecursiveDemo

            public RecursiveDemo(int a)
            {
                if (a < 0)
                    _n = 0;
                else
                    _n = a;
            } //constructor RecursiveDemo

            public int Factorial(int n) //做階層
            {
                if (n == 0)
                    _result = 1;
                else
                    _result = n * Factorial(n - 1);

                return _result;
            } //Factorial

            public void ShowFactorial()
            {
                Console.WriteLine("Factorial [{0}] = {1}\n", _n, _result);
            } //ShowFactorial
        } //class RecursiveDemo
        static void Main(string[] args)
        {
            Console.WriteLine("110213076 鄭鈺曄");

            string str01 = "A B C", str02 = "D E F";
            int i = 0;
            string[] alpha_1 = str01.Split(' ');
            string[] alpha_2 = str02.Split(' ');

            int length_1 = alpha_1.Length;
            int length_2 = alpha_2.Length;

            Console.ReadLine();
        }
    }
}
