using LabaN11;

//1.Создать массив целых чисел(случайно и от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были 10, затем 8, после 6, а далее в обычном порядке. Пример 10, 8, 8 ,25,14,3…
//2.	Создать массив double (случайно и от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были числа без дробной части, а после числа были бы отсортированы по дробной части. Пример 10,15,22, 90.01,3.02,1.25 ….
//3.	Создать массив целых чисел(случайно и от руки).
//Отсортировать его при помощи Array.Sort так, по остаткам от деления на 3, а в пределах остатка в  обычном порядке. Пример  3,6,9, 4,10,13, 5,8 …
//7.	Создать массив String(от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были слова из 3х букв, затем из 5 ти букв, затем из 6ти букв, а дальше все по алфавиту.





//4.	Создать массив char (только буквы)(случайно и от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были гласные в  алфавитном порядке, а после согласные в алфавитном порядке. Пример a, i, b, c, f… 

var arr4 = Console.ReadLine().ToCharArray();
Array.Sort(arr4, new CharComparer());
Console.WriteLine(arr4);

//5.	Создать массив String (от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были слова с наименьшим количеством букв.

var arr5 = Console.ReadLine().Split(' ');
Array.Sort(arr5, new StringComparer());
Console.WriteLine(String.Join(' ', arr5));

//6.	Создать массив String (от руки).
//Отсортировать его при помощи Array.Sort так, чтобы вначале были слова с наибольшим количеством гласных букв.

var arr6 = Console.ReadLine().Split(' ');
Array.Sort(arr6, new StringComparer2());
Console.WriteLine(String.Join(' ', arr6));



var myArray = new MyArray();

var array1 = new MyArray(10);
myArray.AddToArray(array1);
Array.Sort(array1.Array);

foreach (var item in array1.Array)
{
    Console.Write(item + " ");
}

var array2 = new MyArray(10);
myArray.AddToArray(array2);

Console.WriteLine($"Расхождения на индексе:{myArray.CompareArrays(array1, array2)}");
myArray.VievArray(array1);

public class CharComparer : IComparer<char> //4
{
    char[] vovels = { 'a', 'e', 'i', 'o', 'u' };
    char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z' };
    public int Compare(char a, char b)
    {
        if (consonants.Contains(a) && vovels.Contains(b))
            return 1;
        if (vovels.Contains(a) && consonants.Contains(b))
            return -1;
        return a.CompareTo(b);
    }

}

public class StringComparer : IComparer<string> //5
{
    public int Compare(string x, string y)
    {
        return x.Length - y.Length;
    }
}

public class StringComparer2 : IComparer<string> //6
{
    public int Compare(string? x, string? y)
    {
        if (x.Length < y.Length) return 1;
        if (x.Length > y.Length) return -1;
        return 0;
    }
}

