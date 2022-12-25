//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
using static System.Console;
using System.Linq;
using System;
using static MyLibrary;

public class SortArrTwoInt
{
    public static void Main()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 

        int m = Input($"Введите количество столбцов массива: ");
        int n = Input($"Введите количество строк массива: ");

        int[,] arr = CreateArrayIntTwo(m, n);
        int max;
        int exchange;

        //Заполняем массив случайными числами.
        FillRandIntTwo(arr, 0, true, 100, true);
        WriteLine($"Исходный массив: ");
        WriteLine(PrintGoodTwo(arr, 1));
        WriteLine();
        //Сортируем элементы каждой строки массива
        max = arr[0, 0];
        exchange = max;
        SortMethod(m, n, arr, max, exchange);
        WriteLine($"Отсортированный массив:");
        WriteLine(PrintGoodTwo(arr, 1));
        WriteLine();
    }
    static void SortMethod(int m, int n, int[,] arr, int max, int exchange)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                max = arr[i, j];
                for (int k = j + 1; k < n; k++)
                {
                    if (arr[i, k] > max)
                    {
                        exchange = max;
                        max = arr[i, k];
                        arr[i, k] = exchange;
                    }
                }
                arr[i, j] = max;

            };
        };
    }
}

