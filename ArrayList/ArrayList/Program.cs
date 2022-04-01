// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MyArrayList<int> IntList = new MyArrayList<int>();
IntList.Add(0);
IntList.Add(1);
IntList.Add(2);
IntList.Add(3);
IntList.Add(4);
IntList.Add(5);
IntList.Add(6);
IntList.Add(7);
IntList.Add(8);
IntList.Add(9);
Console.WriteLine(IntList.GetSize());
Console.WriteLine(IntList.GetElementAtIndex(8));