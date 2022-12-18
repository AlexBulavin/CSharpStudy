//Показать двумерный массив размером m×n заполненный вещественными числами
using static MyLibrary;
using static System.Console;
Console.Clear();

int m = Input("Введите количество строк двумерного массива: ");
int n = Input("Введите количество столбцов двумерного массива: ");
double[,] arr = CreateArrayDouble(m, n);

//Заполняем массив рандомными вещественными числами от 0 до 99
FillRandDoubleTwo(arr, 0,  0, true, 100000, 100, 6, true);
Write($"{PrintGoodTwo(arr, 1)}\n");

