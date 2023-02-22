using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("110213076 鄭鈺曄");

            int[] data = new int[10];
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int i = 0;
            int min = 0;

            for (i = 0; i < 10; i++)
                data[i] = rnd.Next(-100,100);

            Console.Write("原始資料: ");
            foreach (int obj in data)
                Console.Write(obj + " ");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                min = Math.Min(min, data[i]);
            } //for

            Console.WriteLine($"最小值 ={min}");
            Console.ReadLine();
        }
    }
}
