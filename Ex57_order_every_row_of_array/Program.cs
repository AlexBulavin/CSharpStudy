//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];
int max;
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

Console.WriteLine("Сортируем элементы каждой строки массива:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {   
        max = arr[i, j];
        for (int k = j+1; k < n; k++)
        {
            if (arr[i, k] > max) 
            {
                exchange = max; 
                max = arr[i, k];
                arr[i, k] = exchange;
            }
        }
        arr[i, j] = max; 
        Console.Write($"{arr[i, j]} \t");
    };
    Console.WriteLine();
};
Console.WriteLine();
