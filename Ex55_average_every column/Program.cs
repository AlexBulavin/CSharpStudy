//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
using static MyLibrary;
using static System.Console;
Console.Clear();//Очищаем консоль
bool DEBUG = false;//true;//
int n = Input("Введите количество строк двумерного массива: ");
int m = Input("Введите количество столбцов двумерного массива: ");

int[,] arr = CreateArrayIntTwo(n, m);
float[] average = CreateArrayFloat(m);

//Заполняем массив случайными числами и вычисляем среднее значение.
FillRandIntTwo(arr, 0, true, 100, true);

//Выводим полученный массив на печать
Write(PrintGoodTwo(arr, 1));
WriteLine("Средние значения по столбцам:");

for (int i = 0; i < m; i++)//Идём по столбцам
{
    for (int j = 0; j < n; j++)//Идём по строкам
        {
        if (DEBUG) WriteLine($" n (кол-во строк) = {n}, m (кол-во столбцов) = {m}, i = {i}, j = {j}, arr[i,j] = {arr[i,j]}, average[i] = {average[i]}");
        average[i] += arr[j, i]; //Суммируем элементы по столбцу
        }
    average[i] = average[i]/n;//Вычисляем среднее значение
}
//Выводим средние значения в заданном цвете
ChangeForegroundColor(4);
Write(PrintGood(average, 1));
ResetColor();
WriteLine();