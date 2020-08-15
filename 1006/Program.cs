using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()), b = num / 100, s = (num % 100) / 10, g = num % 10;
            for (int i = 0; i < b; i++)
                Console.Write("B");
            for (int i = 0; i < s; i++)
                Console.Write("S");
            for (int i = 1; i <= g; i++)
                Console.Write(i);
        }
    }
}