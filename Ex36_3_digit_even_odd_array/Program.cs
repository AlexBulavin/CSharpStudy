//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[50];
Random r = new Random();
int even_count = 0;
int odd_count = 0;

//Заполняем массив рандомными числами от 100 до 999
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(100, 999);
    if (arr[i] % 2 == 0)
    {even_count++;}
    else
    {odd_count++;};
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine();

Console.Write("В массиве " + even_count + " чётных и " + odd_count + " нечётных чисел\n");

