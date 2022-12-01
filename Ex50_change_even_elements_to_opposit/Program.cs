//В двумерном массиве n×k заменить четные элементы на противоположные
Console.Write("Введите размер массива nxk\n");
int n = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Создаём массив " + n + " x " + k + "\n");

int[,] arr = new int[n, k];
Random r = new Random();

//Заполняем массив рандомными числами от 0 до 99
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        arr[i, j] = r.Next(0, 200);
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
    
}
Console.WriteLine("---------------------------------Проверяем массив на чётность и заменяем вместо чётных Arr[i, j] противоположные элементы массива Arr[n - i -1, k - j - 1] \n");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        if (arr[i, j] % 2 == 0)
        {
            arr[i, j] = arr[n-i-1, k-j-1];
        };
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
    
}