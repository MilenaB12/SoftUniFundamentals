int startNumber = int.Parse(Console.ReadLine());
int lastNumber = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = startNumber; i <= lastNumber; i++)
{
    Console.Write(i + " ");
    sum += i;
}

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
