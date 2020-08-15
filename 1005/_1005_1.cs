using System;
using System.Collections.Generic;

namespace _1005_1
{
    class _1005_1
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            List<Callatz> keyValues = new List<Callatz>();
            string[] temp = Console.ReadLine().Split(' ');
            for (int i = 0; i < k; i++)
            {
                int sample = int.Parse(temp[i]);
                if (keyValues.Count == 0)
                    keyValues.Add(new Callatz(sample));
                else
                    if (!isCovered(keyValues, sample))
                        keyValues.Add(new Callatz(sample));
            }
            //二次验证
            for (int i = 0; i < keyValues.Count;)
            {
                bool isRemoved = false;
                for (int j = keyValues.Count - 1; j > i; j--)
                    if (keyValues[j].hasCovered(keyValues[i].root))
                    {
                        keyValues.RemoveAt(i);
                        isRemoved = true;
                        break;
                    }
                if(isRemoved == false)
                    i++;
            }
            //大到小排序
            keyValues.Sort();
            for (int i = 0; i < keyValues.Count; i++)
                if (i != keyValues.Count - 1)
                    Console.Write(keyValues[i].root + " ");
                else
                    Console.Write(keyValues[i].root + "\n");
        }
        //检查是否属于已经存在的关键序列
        static bool isCovered(List<Callatz> keyValues, int sample)
        {
            foreach(Callatz key in keyValues)
                if (key.hasCovered(sample))
                    return true;
            return false;
        }
    }

    class Callatz : IComparable<Callatz>
    {
        public int root { get; set; }
        public List<int> resultSet = new List<int>();
        public Callatz(int root)
        {
            this.root = root;
            getResultSet();
        }
        private void getResultSet()
        {
            int res = root;
            while (res != 1)
            {
                //奇数
                if ((res & 1) == 1)
                    res = 3 * res + 1;
                res /= 2;
                resultSet.Add(res);
            }
        }
        public bool hasCovered(int num)
        {
            if (root == num)
                return true;
            foreach (int n in resultSet)
                if (n == num)
                    return true;
            return false;
        }
        public int CompareTo(Callatz other)
        {
            return -(root.CompareTo(other.root));
        }
    }
}
