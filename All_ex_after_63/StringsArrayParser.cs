/*Создать приложение по обработке двумерного массива строк.
Если сложно, массив может сделать одномерным

Приложение позволяет сгенерирвать массив и показать сколько в этом массиве "слов" содержащих восклицательный знак ("!")

Требование: минимум 4 метода, IndexOf использовать нельзя */
using static MyLibrary;
using static System.Console;
public class StringArrayParser
{
    public static void Parser1()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - прод или дебаг
        int n = Input("Введите количество строк двумерного массива: ");
        int m = Input("Введите количество столбцов двумерного массива: ");

        string[,] arr = CreateArrayStringTwo(n, m);

        //Заполняем массив "словами".
        ChangeForegroundColor(4);
        WriteLine($"\nКоличество ! в массиве равно: {FillRandStringTwo(arr, DEBUG)}\n");

        //Выводим полученный массив на печать
        ChangeForegroundColor(8);
        WriteLine(PrintGoodTwo(arr, 2));
        WriteLine();
        Console.ResetColor();
    }
}