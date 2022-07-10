using LabaN11._2;

var myArray = new MyArray();



var array1 = new MyArray(20, "Первый");
myArray.AddToArray(array1);
foreach (var item in array1.GetEnumerator2())
{
    Console.WriteLine(item);
}

var array2 = (MyArray)array1.Clone();
myArray.AddToArray(array2);
array2.Name = "Второй";

var array3 = new MyArray(20, "Третий");
myArray.AddToArray(array3);

var array4 = new MyArray(20);
myArray.AddToArray(array4);

var array5 = new MyArray(20);
myArray.AddToArray(array5);



var megaArray = new ArrayOfArrs();
megaArray.Add(array1);
megaArray.Add(array2);
megaArray.Add(array3);
megaArray.Add(array4);
megaArray.Add(array5);

foreach (MyArray arr in megaArray.GetEnumerator())
{
    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}