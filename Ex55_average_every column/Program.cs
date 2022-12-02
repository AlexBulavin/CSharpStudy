//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];
int[] average = new int[n];

//Заполняем массив случайными числами. Если i и j чётные, то квадратами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(5, 20);
        average[j] = (average[j] + arr[i, j])/2;
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
};

Console.WriteLine("Средние значения по столбцам:");

for (int i = 0; i < n; i++)
{
    Console.Write($"{average[i]} \t");
}
Console.WriteLine();

