//Найти сумму чисел одномерного массива стоящих на нечетной позиции
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[123];
Random r = new Random();
int sum = 0;

//Заполняем массив рандомными числами от 0 до 999
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 999);
    if (i % 2 == 0) sum += arr[i];
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine();

Console.Write("Сумма нечётных элементов массива = " + sum + "\n");
