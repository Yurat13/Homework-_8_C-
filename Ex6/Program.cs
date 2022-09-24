// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void SequenceNumber (int a, int b, int size)
{
    if (size == 0) return;
    else 
    {
    Console.Write((a + b) + " ");
    SequenceNumber (b, a+b, size-1);
    }
}

Console.WriteLine("Enter number a:");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number b:");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter number size:");
int size = int.Parse(Console.ReadLine() ?? "0");
SequenceNumber(a, b, size);