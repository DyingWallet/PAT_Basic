using System;
using System.Collections.Generic;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            List<int> input = new List<int>();
            for (int i = 0; i < temp.Length; i++)
                if (!temp[i].Equals(""))
                    input.Add(int.Parse(temp[i]));
            int coe = input[0], index = input[1];
            if (index == 0)
                Console.Write("0 0");
            else
            {
                Console.Write((coe * index) + " " + (index - 1));
                for (int i = 2; i < input.Count; i++)
                {
                    coe = input[i++];
                    index = input[i];
                    if (index == 0)
                        break;
                    else if (coe != 0)
                        Console.Write(" " + (coe * index) + " " + (index - 1));
                }
            }
        }
    }
}