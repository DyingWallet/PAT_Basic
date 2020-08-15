using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] res = { 0, 0, 0, 0, 0 };
            int count_a2 = 0, count_a4 = 0;
            for (int i = 1; i < input.Length; i++)
            {
                int temp = int.Parse(input[i]);
                if (temp % 10 == 0)
                    res[0] += temp;
                if (temp % 5 == 1)
                    res[1] += Math.Pow(-1, count_a2++) * temp;
                if (temp % 5 == 2)
                    res[2]++;
                if (temp % 5 == 3)
                {
                    res[3] += temp;
                    count_a4++;
                }
                if (temp % 5 == 4)
                    if (res[4] < temp)
                        res[4] = temp;
            }
            if (count_a4 > 0)
                res[3] /= count_a4;
            for (int i = 0; i < res.Length; i++)
            {
                if (i != 0)
                    Console.Write(" ");
                //res[0,2,4]
                if (res[i] == 0 && (i & 1) != 1)
                {
                    Console.Write("N");
                    continue;
                }
                //res[1,3]
                else if (res[i] == 0 && (i & 1) == 1)
                {
                    if ((i == 1 && count_a2 == 0) || (i == 3 && count_a4 == 0))
                    {
                        Console.Write("N");
                        continue;
                    }
                }
                if (i != 3)
                    Console.Write(res[i].ToString("0"));
                else
                    Console.Write(res[i].ToString("0.0"));
            }
        }
    }
}