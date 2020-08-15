using System;
using System.Collections.Generic;
//大侦探福尔摩斯接到一张奇怪的字条：我们约会吧！ 3485djDkxh4hhGE 2984akDfkkkkggEdsb s&hgsfdk d&Hyscvnm。
//大侦探很快就明白了，字条上奇怪的乱码实际上就是约会的时间星期四 14:04，
//因为前面两字符串中第 1 对相同的大写英文字母（大小写有区分）是第 4 个字母 D，代表星期四；
//第 2 对相同的字符是 E ，那是第 5 个英文字母，代表一天里的第 14 个钟头（于是一天的 0 点到 23 点由数字 0 到 9、以及大写字母 A 到 N 表示）；
//后面两字符串第 1 对相同的英文字母 s 出现在第 4 个位置（从 0 开始计数）上，代表第 4 分钟。现给定两对字符串，请帮助福尔摩斯解码得到约会的时间。
namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "MON ", "TUE ", "WED ", "THU ", "FRI ", "SAT ", "SUN " };
            List<char[]> letter = new List<char[]>();
            for (int i = 0; i < 4; i++)
                letter.Add(Console.ReadLine().ToCharArray());
            bool foundDay = false;
            for (int i = 0; i < letter.Count; i += 2)
            {
                char[] str1 = letter[i], str2 = letter[i + 1];
                for (int j = 0; j < ((str1.Length < str2.Length) ? str1.Length : str2.Length); j++)
                {
                    if (i == 0)
                    {
                        //周几
                        if (!foundDay && str1[j] == str2[j] && 'A' <= str1[j] && str1[j] <= 'G')
                        {
                            Console.Write(weekDays[str1[j] - 'A']);
                            foundDay = true;
                            continue;
                        }
                        //几点
                        if (foundDay && str1[j] == str2[j] && (('A' <= str1[j] && str1[j] <= 'N') || ('0' <= str1[j] && str1[j] <= '9')))
                        {
                            if ('0' <= str1[j] && str1[j] <= '9')
                                Console.Write("0" + (str1[j] - '0') + ":");
                            else
                                Console.Write((str1[j] - 'A' + 10) + ":");
                            break;
                        }
                    }
                    else
                    {
                        if (str1[j] == str2[j] && char.IsLetter(str1[j]))
                        {
                            if ((j / 10) == 0)
                                Console.Write("0" + j);
                            else
                                Console.Write(j);
                            break;
                        }
                    }
                }
            }
        }
    }
}