using System;
using System.Collections.Generic;

namespace _1005_2
{
    class _1005_2
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            List<int> samples = new List<int>();
            List<int> resultSet = new List<int>();
            for (int i = 0; i < k; i++)
                samples.Add(int.Parse(temp[i]));
            samples.Sort(SortCompare);
            for (int i = 0; i < k; i++)
            {
                int res = samples[i];
                if (resultSet.Find(n => n.Equals(res)) == 0)
                    while (res != 1)
                    {
                        if ((res & 1) == 1)
                            res = res * 3 + 1;
                        res /= 2;
                        if (resultSet.Find(n => n.Equals(res)) != 0)
                            break;
                        resultSet.Add(res);
                    }
            }
            resultSet.Sort(SortCompare);
            for (int i = 0, j = 0; i < k; i++)
                if (resultSet.Find(n => n.Equals(samples[i])) == 0)
                {
                    if (j++ == 0)
                        Console.Write(samples[i]);
                    else
                        Console.Write(" " + samples[i]);
                }
        }
        static int SortCompare(int m, int n)
        {
            return n.CompareTo(m);
        }
    }
}
