using System;
using System.Collections;

namespace LabaN11._2
{
    public class MyArray : ICloneable, IEnumerable
    {
        public int[] Array;
        public int N { get; set; }
        public string Name { get; set; }
        public MyArray()
        {

        }
        public MyArray(int n)
        {
            N = n;
            Array = new int[N];
        }
        public MyArray(int n, string name)
        {
            N = n;
            Name = name;
            Array = new int[N];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        public void AddToArray(MyArray arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.N; i++)
            {
                arr.Array[i] = rnd.Next(0, 20);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => Array.GetEnumerator();

        // 1. Реализовать обход через каждый 3й элемент.
        public IEnumerable GetEnumerator1()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (i != 0 && i % 3 == 0)
                    continue;
                yield return Array[i];
            }
        }
        //2. Реализовать обход с конца в начало каждый 2й элемент.
        public IEnumerable GetEnumerator2()
        {
            for (int i = Array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    continue;
                yield return Array[i];
            }
        }
    }
}