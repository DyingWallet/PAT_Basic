using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lim = Console.ReadLine().Split();
            int count = 0, max = 10000000, startIndex = int.Parse(lim[0]), endIndex = int.Parse(lim[1]);
            bool notPrime = true;
            for (int current = 2, index = 0; current < max && index < endIndex; current++)
            {
                notPrime = true;
                if (current < 5)
                {
                    if (current == 2 || current == 3)
                    {
                        index++;
                        notPrime = false;
                    }
                }
                else
                {
                    if (current % 6 != 1 && current % 6 != 5)
                        continue;
                    notPrime = false;
                    int sqrt = (int)Math.Sqrt(current);
                    for (int fac = 5; fac <= sqrt; fac += 6)
                        if (current % fac == 0 || current % (fac + 2) == 0)
                        {
                            notPrime = true;
                            break;
                        }
                    if (!notPrime)
                        index++;
                }
                if (index >= startIndex && !notPrime)
                {
                    count++;
                    int flag = count % 10;
                    if (flag != 1)
                        Console.Write(" ");
                    Console.Write(current);
                    if (flag == 0)
                        Console.WriteLine();
                }
            }
        }
    }
}