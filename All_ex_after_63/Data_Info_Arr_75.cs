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

        //Нужно переписать это на preset data или делать динамическим массивом
        int[] data;
        int[] info;

        ChangeForegroundColor(4);
        //TODO сделать методы для создания их автоматическим методом
        //2. Создать метод автогенерации массива с двоичными данными на основании массива с десятичными данными;
        //3. Создать метод ручного ввода.

        int selectDataGenerate = 0;
        //1. Запросить пользователя способ создания массива: 1 - предустановленный; 2 - автоматическим рандомным от 3 до 20; 3 - вручную;
        while (selectDataGenerate < 1 | selectDataGenerate > 3)
            selectDataGenerate = Input($"Выберите способ создания массива данных: 1 - предустановленный; 2 - автоматическим рандомным от 3 до 20; 3 - вручную;");

        if (selectDataGenerate == 1)
        {
            //Создаём массивы хардкодом
            //Они уже созданы
            if (DEBUG) WriteLine($"Используем предустановленные данные");
            data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
            info = new int[] { 2, 3, 3, 1 };
            PrintOutResult(DEBUG, data, info);
        }
        else if (selectDataGenerate == 2)
        {
            //2. Создаём массивы автоматическим рандомным от 3 до 20
            int[] sourceData = CreateArrayInt(Random.Shared.Next(3, 21));
            FillRandInt(sourceData, 0, true, 100, true);
            autoDataAndInfoArrFilling(DEBUG, out data, out info, sourceData);
        }
        else if (selectDataGenerate == 3)
        {
            //3. Создать метод ручного ввода.
            int[] sourceData = new int[Input("Укажите размер массива данных")];
            for (int i = 0; i < sourceData.Length; i++) sourceData[i] = Input($"sourceData[{i}] = ");
            autoDataAndInfoArrFilling(DEBUG, out data, out info, sourceData);
        }

        //Выводим получившиеся данные через цикл //рекурсию.
        // PrintOutResult(DEBUG, ref shift, ref result, ref exponent, out data, out info);
        WriteLine("\n");
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
        WriteLine();
    }

    private static void PrintOutResult(bool DEBUG, int[] data, int[] info)
    {
        int shift = 0;
        int exponent = 0;
        int result = 0;
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
    }

    private static void dataAndInfoArrFilling(bool DEBUG, out int[] data, out int[] info, string sourceDataBin, string infoString, int sourceDataBinLength, int infoStringLength)
    {
        //Заполняем массивы data и info
        data = new int[sourceDataBinLength];
        info = new int[infoStringLength];
        for (int i = sourceDataBin.Length - 1; i >= 0; i--)
        {
            data[sourceDataBinLength - i + 1] = sourceDataBin[i];
        }
        for (int i = infoStringLength; i >= 0; i--)
        {
            info[infoStringLength - i + 1] = infoString[i];
        }
        PrintOutResult(DEBUG, data, info);
        printDataAndInfoArr(data, info);
    }
    private static void printDataAndInfoArr(int[] data, int[] info)
    {
        //Заполняем массивы data и info
        //Печатаем исходные массивы
        Write($"data array:");
        SetCursorPosition(15, 0);
        WriteLine(PrintGood(data, 1));

        Write($"info array:");
        SetCursorPosition(15, 1);
        WriteLine(PrintGood(info, 1));
        WriteLine();
    }

    private static void autoDataAndInfoArrFilling(bool DEBUG, out int[] data, out int[] info, int[] sourceData)
    {
        string sourceDataBin = String.Empty;
        string infoString = String.Empty;
        int binCounter;
        int restOfDeviding, leftPartOfDeviding;
        //Конвертируем значения массива в двоичный код и узнаём количество символов в двоичном представлении
        for (int i = 0; i < sourceData.Length; i++)
        {
            restOfDeviding = sourceData[i] / 2;
            leftPartOfDeviding = sourceData[i] % 2;
            binCounter = 1;//Показатель степени для числа в двоичном представлении, то есть элемент массива info
            while (restOfDeviding >= 2)
            {
                sourceDataBin += leftPartOfDeviding;
                binCounter++;
            }
            infoString += binCounter;//Строка с данными по всем длинам двоичных элементов
        }
        int sourceDataBinLength = sourceDataBin.Length;
        int infoStringLength = infoString.Length;
        dataAndInfoArrFilling(DEBUG, out data, out info, sourceDataBin, infoString, sourceDataBinLength, infoStringLength);
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