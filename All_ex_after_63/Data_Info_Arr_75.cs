/*75. Есть два массива info и data. 

Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей. 

Массив info состоит из чисел, которые представляют количество бит чисел из массива data.

Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 
*/

using static MyLibrary;
using static System.Console;
public class DataInfoArr
{
    public static uint depth = 0;//Глубина рекурсии
    public static void DataInfoArrMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 

        ChangeForegroundColor(4);
        //Создаём массивы хардкодом
        //TODO Нужно будет сделать методы для создания их автоматическим методом
        int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
        int[] info = { 2, 3, 3, 1 };
        //TODO сделать методы для создания их автоматическим методом
        //1. Запросить пользователя способ создания массива: 1 - предустановленный; 2 - автоматическим рандомным от 3 до 20; 3 - вручную;
        //2. Создать метод автогенерации массива с двоичными данными на основании массива с десятичными данными;
        //3. Создать метод ручного ввода.

        int shift = 0;
        int result = 0;
        int exponent = 0;

        //Печатаем исходные массивы
        Write($"data array:");
        SetCursorPosition(15,0);
        WriteLine(PrintGood(data, 1));

        Write($"info array:");
        SetCursorPosition(15,1);
        WriteLine(PrintGood(info, 1));
        WriteLine();

        //Выводим получившиеся данные через цикл //рекурсию.
        for (int i = 0; i < info.Length; i++)
        {
            for (int j = shift; j < info[i] + shift; j++)
            {
                exponent = info[i] - 1 - (j - shift);
                if (DEBUG)
                {
                    WriteLine($"Before result incremented\ti = {i}, info[i] = {info[i]}, shift = {shift}, result = {result}, j = {j},");
                    WriteLine($"\nexponent = {exponent}");
                }
                result += data[j] * (int)Math.Pow(2, exponent);
                if (DEBUG)
                {
                    WriteLine($"After result incremented\ti = {i}, info[i] = {info[i]}, shift = {shift}, result = {result}, j = {j}, data[j] = {data[j]}, info[i] - j - shift - 1 = {info[i] - j - shift - 1}\n");
                }
                Write($"{data[j]}*2{CharSelector(exponent < 10 ? exponent : 9, 1, false)}{(exponent > 0 ? (" + ") : (" = "))}{(exponent > 0 ? ("") : ($"{result}\t\t"))}");
            };
            shift += info[i];
            result = 0;
        }
        WriteLine("\n");
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
        WriteLine();
    }
    /*data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
      info = {2, 3, 3, 1 }
    выходные данные:
    1, 7, 0, 1*/

    // public static void RecursionPermutationWords(string baseArr, string w, int n, bool DEBUG)
    // {
    //     if (DEBUG)
    //     {
    //         WriteLine($"DEBUG MODE baseArr = {baseArr}, w = {w}");
    //     }
    //     if (w.Length == n)
    //         Write($"{w}\t");
    //     else

    //         foreach (var letter in baseArr)
    //         {
    //             if (DEBUG)
    //             {
    //                 WriteLine($"DEBUG MODE letter = {letter}");
    //             }
    //             RecursionPermutationWords(baseArr, w + letter, n, DEBUG);
    //         }
    // }
}