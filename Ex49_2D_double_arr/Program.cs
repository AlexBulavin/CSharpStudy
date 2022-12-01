//Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("Введите размер массива MxN\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Создаём массив " + m + " x " + n + "\n");

double[,] arr = new double[m, n];
Random r = new Random();

//Заполняем массив рандомными числами от 0 до 99
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = (float)r.Next(0, 100000)/100000 + r.Next(0, 100);
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
    
}
