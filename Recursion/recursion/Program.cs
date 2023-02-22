// n!
using System;

namespace recursion
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
            RecursiveDemo obj = new RecursiveDemo(5);
            obj.Factorial(obj.GetValue());
            obj.ShowFactorial();

            Console.ReadLine();
        }
     }
}
