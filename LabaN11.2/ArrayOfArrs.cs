using System;
using System.Collections;

namespace LabaN11._2
{
    public class ArrayOfArrs
    {
        public MyArray[] MegaArray;
        private static int n;

        public ArrayOfArrs()
        {
            MegaArray = new MyArray[5];
        }

        public void Add(MyArray arr)
        {
            if (n < MegaArray.Length)
                MegaArray[n] = arr;
            n++;
        }

        // Реализовать обход объектов у которых присутствует заданное имя(или любое другое свойство).
        public IEnumerable GetEnumerator()
        {
            for (int i = 0; i < MegaArray.Length; i++)
            {
                if (MegaArray[i].Name != null)
                    continue;
                yield return MegaArray[i];
            }
        }

    }
}
