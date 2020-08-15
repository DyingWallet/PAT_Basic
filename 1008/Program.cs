using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), m = int.Parse(input[1]) % n;
            input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(input[i]);
            Array.Reverse(arr, 0, n - m);
            Array.Reverse(arr, n - m, m);
            Array.Reverse(arr);
            for (int i = 0; i < n; i++)
                if (i == 0)
                    Console.Write(arr[i]);
                else
                    Console.Write(" " + arr[i]);
        }
    }
}