//Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];

//Заполняем массив числами от Aₘₙ = m+n
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = i + j;
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}