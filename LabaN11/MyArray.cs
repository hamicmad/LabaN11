using System;


namespace LabaN11
{
    ////Создать класс MyArray (массив типа int). В классе описать следующие элементы:
    //•	поля – размерность и элементы;
    //•	конструкторы;
    //•	индексаторы для регулировки выхода индексов за допустимые границы;
    //•	метод сравнения двух объектов (сравнивать поэлементно до первого расхождения);
    //•	метод вывода массива на экран в виде (a0, a1, … , an-1).

    public class MyArray : IComparable<MyArray>
    {
        public int[] Array { get; }
        public int N { get; }
        public MyArray()
        {

        }
        public MyArray(int n)
        {
            N = n;
            Array = new int[N];
        }
        public int this[int index]
        {
            get => Array[index];
            set => Array[index] = value;
        }

        public int CompareTo(MyArray? arr)
        {
            return arr.CompareTo(arr);
        }
        public void AddToArray(MyArray arr)
        {
            var rnd = new Random();
            for (int i = 0; i < arr.N; i++)
            {
                arr[i] = rnd.Next(0, 20);
            }
            for (int i = 0; i < arr.N;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public int CompareArrays(MyArray arr1, MyArray arr2)
        {
            int res = 0;
            for (int i = 0, j = 0; i < arr1.N && j < arr2.N; i++,j++) 
            {
                if (arr1[i] != arr2[j])
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        public void VievArray (MyArray arr)
        {
            for (int i = 0; i < arr.N; i++)
            {
                Console.WriteLine(arr[i] + "-" + i);
            }    
        }

    }
}
