using System;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split(' ');
            for (int i = sentence.Length - 1; i >= 0; i--)
                if (i != 0)
                    Console.Write(sentence[i] + " ");
                else
                    Console.Write(sentence[i]);
        }
    }
}
