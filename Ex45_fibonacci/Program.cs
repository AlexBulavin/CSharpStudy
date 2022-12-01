//Показать числа Фибоначчи
Console.Write("Ищем 100 чисел Фибоначчи\n");
ulong previous = 0;
ulong current = 1;
ulong next = 1;
Console.WriteLine("Число " + previous);
Console.WriteLine("Число " + current);
for (int i = 2; i < 100; i++)
{
    next = previous + current;
    previous = current;
    current = next;
    Console.WriteLine("Число " + next);
}


