// В матрице чисел найти сумму элементов главной диагонали
Console.Write("Введите размер матрицы m\n");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Random r = new Random();

Console.Write($"Создаём матрицу {m} + x + {m} \n");

int[,] arr = new int[m, m];

//Заполняем массив случайными числами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = r.Next(5, 20);
        Console.Write($"{arr[i, j]} \t");
        if (i == j) sum += arr[i, j];
    }
    Console.WriteLine();
};

Console.WriteLine($"Сумма элементов по главной диагонали равна {sum}");