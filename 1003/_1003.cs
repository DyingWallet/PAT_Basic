using System;
using System.Text.RegularExpressions;

//1003 我要通过！ (20分)
//“答案正确”是自动判题系统给出的最令人欢喜的回复。本题属于 PAT 的“答案正确”大派送 —— 只要读入的字符串满足下列条件，系统就输出“答案正确”，否则输出“答案错误”。

//得到“答案正确”的条件是：

//字符串中必须仅有 P、 A、 T这三种字符，不可以包含其它字符；
//任意形如 xPATx 的字符串都可以获得“答案正确”，其中 x 或者是空字符串，或者是仅由字母 A 组成的字符串；
//如果 aPbTc 是正确的，那么 aPbATca 也是正确的，其中 a、 b、 c 均或者是空字符串，或者是仅由字母 A 组成的字符串。
//现在就请你为 PAT 写一个自动裁判程序，判定哪些字符串是可以获得“答案正确”的。

//输入格式：
//每个测试输入包含 1 个测试用例。第 1 行给出一个正整数 n(<10)，是需要检测的字符串个数。接下来每个字符串占一行，字符串长度不超过 100，且不包含空格。

//输出格式：
//每个字符串的检测结果占一行，如果该字符串可以获得“答案正确”，则输出 YES，否则输出 NO。

//输入样例：
//8         
//PAT               YES
//PAAT              YES
//AAPATAA           YES
//AAPAATAAAA        YES
//xPATx             NO
//PT                NO
//Whatever          NO
//APAAATAA          NO

namespace _1003
{
    class _1003
    {
        static Regex regex_hasPT = new Regex(@"^(\s|A*)P(\s|A*)T(\s|A*)$");
        static Regex regex_hasA = new Regex(@".*A.*");
        static Regex regex_split = new Regex(@"^([A]*|\s)$");
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] strs = new string[n];
            for (int i = 0; i < n; i++)
            {
                strs[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                if (Judger(strs[i]))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        private static bool Judger(string str)
        {
            if (regex_hasPT.IsMatch(str) && regex_hasA.IsMatch(str))
            {
                string[] array = str.Split(new char[] { 'P', 'T' });

                if (regex_split.IsMatch(array[0]))
                    if (regex_split.IsMatch(array[1]))
                        if (regex_split.IsMatch(array[2]))
                            if (array[0].Length * array[1].Length == array[2].Length)
                                return true;
            }
            return false;
        }
    }
}
