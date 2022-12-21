using static MyLibrary;
using static System.Console;

public class Seminar_17_12_2022
{
    public static void Task1()
    {
        //Составить частотный словарь элементов двумерного массива
        bool DEBUG = false;//true;//
        Console.Clear();
        int saveCursorSize = Console.CursorSize;
        string selectInput = Select("Вводим текст вручную?  Y/N: ", 100);
        if (!OperatingSystem.IsMacOS()) Console.CursorSize = saveCursorSize;

        int arrSize;
        if (DEBUG) WriteLine($"Выбрано значение {selectInput}");
        if (String.Equals(selectInput, "Y")
                | String.Equals(selectInput, "D")
                | String.Equals(selectInput, "Д")
                | String.Equals(selectInput, "1")
                | String.Equals(selectInput, "Н")
                | String.Equals(selectInput, "у")
                | String.Equals(selectInput, "У"))
        {
            arrSize = Input("Введите размер массива arrSize ");
            int[] arr = CreateArrayInt(arrSize);
            for (int i = 0; i < arrSize; i++) arr[i] = Input($"arr[{i}] = ");

            //Основная логика - подсчёт частоты элементов массива
            MainCodeFrequencyArr(arr, DEBUG);
        }
        else
        {
            //Задаём случайным образом размер массива
            arrSize = Random.Shared.Next(50, 100);
            int[] arr = CreateArrayInt(arrSize);

            //Заполняем массив случайными числами.
            FillRandInt(arr, 950, true, 1000, false);

            //Основная логика - подсчёт частоты элементов массива
            MainCodeFrequencyArr(arr, DEBUG);
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

}