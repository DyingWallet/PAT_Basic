using System;
using System.Diagnostics;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine()), count = 0, pre;
            bool notPrime = false;
            if (max >= 5)
            {
                pre = 5;
                count++;
                for (int curr = 7; curr <= max; curr++)
                {
                    //只有满足6x-1,6x+1的数才可能是质数
                    if (curr % 6 != 1 && curr % 6 != 5)
                        continue;
                    int sqrt = (int)Math.Sqrt(curr);
                    //比较是否有小于sqrt的奇数能够整除curr
                    for (int j = 5; j <= sqrt; j += 6)
                        if (curr % j == 0 || curr % (j + 2) == 0)
                        {
                            notPrime = true;
                            break;
                        }
                        else
                            notPrime = false;
                    if (!notPrime)
                    {
                        if (curr - pre == 2)
                        {
                            count++;
                        }
                        pre = curr;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}