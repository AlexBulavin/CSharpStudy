//В прямоугольной матрице найти строку с наименьшей суммой элементов.
using static System.Console;
using System.Linq;
using System;
using static MyLibrary;

public class MinRowSumTwoInt
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
        int[] sumArr = CreateArrayInt(n);

        //Заполняем массив случайными числами.
        FillRandIntTwo(arr, 0, true, 100, true);
        int min = arr[0, 0];
        int minIndex = 0;
        WriteLine(PrintGoodTwo(arr, 1));
        //Вычисляем строку с наименьшей суммой элементов
        CountMinStringSum(n, m, arr, sumArr, ref min, ref minIndex);

        WriteLine($"Выводим {minIndex} строку массива с минимальной суммой элементов {min}:");
        WriteLine(PrintGood(arr, minIndex, 1));
        WriteLine();
    }
    static void CountMinStringSum(int m, int n, int[,] arr, int[] sumArr, ref int min, ref int minIndex)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sumArr[i] += arr[i, j];
            }
            if (i == 0)
            {
                min = sumArr[i];
                minIndex = 0;
            }
            else
            {
                if (min < sumArr[i])
                {
                    min = sumArr[i];
                    minIndex = i;
                }
            }
        }
    }

}