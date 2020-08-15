using System;
using System.Collections.Generic;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] conditions = Console.ReadLine().Split(' ');
            int stuCount = int.Parse(conditions[0]), passLine = int.Parse(conditions[1]), goodLine = int.Parse(conditions[2]);
            List<Student> stus = new List<Student>();
            for (int i = 0; i < stuCount; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                if (int.Parse(temp[1]) >= passLine && int.Parse(temp[2]) >= passLine)
                    stus.Add(temp);
            }


        }
    }
    class Student : IComparable<Student>
    {

    }
}
