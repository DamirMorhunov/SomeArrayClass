using SomeArrayClass;

MyArray<int> arr = new();
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