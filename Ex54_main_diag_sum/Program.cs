// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Write("Введите размер матрицы m\n");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Random r = new Random();

Console.Write($"Создаём матрицу {m} + x + {m} \n");

int[,] arr = new int[m, m];

//Заполняем массив случайными числами. Если i и j чётные, то квадратами.
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