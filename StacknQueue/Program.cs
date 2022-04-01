// See https://aka.ms/new-console-template for more information
using StacknQueue;
Console.WriteLine("Hello, World!");
Stak<int> Numbers = new Stak<int>();
Numbers.Push(1);
Numbers.Push(2);
Numbers.Push(3);
Numbers.Push(4);
Numbers.Push(5);
Numbers.Push(6);
Console.WriteLine(Numbers.Pop());
Console.WriteLine(Numbers.Pop());
Console.WriteLine(Numbers.Pop());
Console.WriteLine(Numbers.Pop());

BananaQ<string> Snacks = new BananaQ<string>();
Snacks.Enqueue("Camotecue");
Snacks.Enqueue("Barbecue");
Snacks.Enqueue("Bananacue");

Console.WriteLine(Snacks.Dequeue());
Console.WriteLine(Snacks.Dequeue());
Console.WriteLine(Snacks.Dequeue());