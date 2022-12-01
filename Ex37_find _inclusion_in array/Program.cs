//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[123];
Random r = new Random();
int count = 0;


//Заполняем массив рандомными числами от 0 до 999
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 999);
    if (arr[i] > 10 & arr[i] < 99) count ++;
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine();

Console.Write("В массиве " + count + " чисел из диапазона 10, 99\n");
