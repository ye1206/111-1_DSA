using System;

namespace Quiz4WithOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("請輸入5個整數: ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (i = 0; i < numbers.Length; i++)
            {
                OOPQueue obj1 = new OOPQueue(numbers[i]);
                obj1.Process();
                obj1.ShowAnswer();
                Console.WriteLine();
            } //for

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } //Main
    }
}
