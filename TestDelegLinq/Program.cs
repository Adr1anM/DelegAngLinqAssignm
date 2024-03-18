// See https://aka.ms/new-console-template for more information
using TestDelegLinq;

Console.WriteLine("Hello, World!");


List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
Util.Transform(list, Square);
Console.WriteLine("After transform");
PrintList(list);

list.DevideByTwo(x => x / 2);
Console.WriteLine("\nAfter Division");
PrintList(list);

int closure = 15;

Func<int, int> AddByFactor = delegate (int x)
{
    return x + closure;
};
closure = 20;

for(int i = 0; i < list.Count; i++ )
{
    list[i] = AddByFactor(list[i]);
}
Console.WriteLine();
PrintList(list);
static int Square(int value) => value * value;


static void PrintList(List<int> list)
{
    
    foreach (int item in list)
    {

        Console.Write(item+ " ");
    }
}