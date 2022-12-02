//Написать программу, которая обменивает элементы первой строки и последней строки
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];
int exchange;

//Заполняем массив случайными числами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(0, 100);
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
};

Console.WriteLine("Заменяем элементы первой и последней строк и выводим измененный массив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0) 
        {
            exchange = arr[i, j];
            arr[i, j] = arr[m-1, j];
            arr[m-1, j] = exchange;
        }
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
};
Console.WriteLine();