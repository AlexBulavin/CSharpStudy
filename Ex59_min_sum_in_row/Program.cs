//В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];
int[] sumArr = new int[m];
int min = 0;
int minIndex = 0;

//Заполняем массив случайными числами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(0, 100);
        Console.Write($"{arr[i, j]} \t");
        sumArr[i] += arr[i, j];
    }
    if (i == 0)
    {
        min = sumArr[i];
        minIndex = 0;
    }
    else
    {
        if (min < sumArr[i])
        {
            min = sumArr[i];
            minIndex = i;
        }
    }
    Console.WriteLine();
};

Console.WriteLine($"Выводим {minIndex} строку массива с минимальной суммой элементов {min}:");

for (int i = 0; i < n; i++)
{
    Console.Write($"{arr[minIndex, i]} \t");
};
Console.WriteLine();