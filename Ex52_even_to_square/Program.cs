// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];

//Заполняем массив случайными числами. Если i и j чётные, то квадратами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(5, 20);
        if (i % 2 == 0 & j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
