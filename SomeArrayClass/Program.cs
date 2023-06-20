using Collections;

Array<int> arr = new();
arr.Add(1);
arr.Add(2);
arr.Add(3);
arr.Add(4);
arr.Add(5);
arr.Print();
//arr.Remove();
//arr.Clear();
//Console.WriteLine(arr.RemoveAt(2));
Console.WriteLine(arr.Insert(2,111));
arr.Print();
foreach (int i in arr)
    Console.WriteLine(i);
Array<int> array = new Array<int> {1,2,3,2,1};
var arr2 = array.Distinct();
foreach (int i in arr2)
{
    Console.Write(i +"  ");
}
Console.WriteLine();
List<int> list = new List<int>() { 1, 2, 4, 1 };
Console.WriteLine(list[2]);
array[2] = 32;
Console.WriteLine(array[2]);
