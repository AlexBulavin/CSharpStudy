//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[12];
Random r = new Random();
int positive = 0;
int negative = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(-9, 9);
    if (arr[i] < 0) negative ++;
    else positive ++;
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine("\nКоличество положительных элементов = " + positive);
Console.WriteLine("Количество отрицательных элементов = " + negative);
Console.WriteLine();
