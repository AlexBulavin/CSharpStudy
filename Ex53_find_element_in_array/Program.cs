// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
bool trigger = false;
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];

//Заполняем массив случайными числами. Если i и j чётные, то квадратами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(5, 20);
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
};

Console.Write("Задайте число, которое нужно найти в массиве:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j] == number)
        {
            Console.Write($"Элемент {arr[i, j]} найден, имеет индексы [{i}, {j}] \n");
            trigger = true;
            break;
        }   
        if (trigger) break;
    }   
    if (trigger) break;
}
if (!trigger) Console.WriteLine($"\nЭлемент {number} не найден\n");
