//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

if (m != n) Console.Write("Количество столбцов и строк не одинаковое, транспонировать матрицу невозможно\n");
else
{
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

    Console.WriteLine("Выводим транспонированный массив:");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {   
            if (j > i) 
            {
                exchange = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = exchange;
            };
            Console.Write($"{arr[i, j]} \t");
        };
        Console.WriteLine();
    };
    Console.WriteLine();
}


