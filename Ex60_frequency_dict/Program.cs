//Составить частотный словарь элементов двумерного массива
Console.Write("Введите размер массива mxn\n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

Console.Write("Создаём массив " + m + " x " + n + "\n");

int[,] arr = new int[m, n];
int[] frequancyArr = new int[m*n];

//Заполняем массив случайными числами.
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = r.Next(100, 120);
        frequancyArr[n*i + j] = arr[i, j];
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
};

//Сортируем массив матёрым способом
for (int i = 0; i < frequancyArr.Length - 1; i++)
for (int j = i + 1; j < frequancyArr.Length; j++)
if (frequancyArr[i] > frequancyArr[j]) frequancyArr[i] = frequancyArr[i] + frequancyArr[j] - (frequancyArr[j] = frequancyArr[i]);

//Вычисляем повторения
var dict = new Dictionary<int, int>();
foreach (var value in frequancyArr)
    {
        if (dict.ContainsKey(value))   // с помощью Dictionary и ContainsKey производим подсчет разных элементов и их количество
        dict[value]++;
    else
        dict[value] = 1;
    }
foreach (var pair in dict)
    {
        Console.Write($"{pair.Key} встречается {pair.Value}");
        Console.WriteLine(pair.Value%10 == 1 | pair.Value%10  == 5 | pair.Value%10  == 6 | pair.Value%10  == 7 | pair.Value%10  == 8%10  | pair.Value%10  == 9 | pair.Value%10  == 0 ? " раз" : " раза");
    }