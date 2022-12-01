//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

float[] arr = new float[30];
Random r = new Random();
float min = 0;
float max = 0;

//Заполняем массив рандомными числами от 0 до 99
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = (float)r.Next(0, 100000)/100000 + r.Next(0, 100);
    if ( i == 0 ) min = max = arr[i];
        else if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine("\nРазница между максимальным " + max + " и минимальным " + min + " значениями равна " + (max - min));

Console.Write("\n");
