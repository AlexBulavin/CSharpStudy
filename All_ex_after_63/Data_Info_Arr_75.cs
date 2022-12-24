/*75. Есть два массива info и data. 

Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей. 

Массив info состоит из чисел, которые представляют количество бит чисел из массива data.

Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 
*/
//<GenerateDocumentationFile>True</GenerateDocumentationFile>

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
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 

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
            selectDataGenerate = Input($"Выберите способ создания массива данных:\n1 - предустановленный;\n2 - автоматическим рандомным от 3 до 20;\n3 - вручную;\n");
        if (DEBUG) WriteLine($"selectDataGenerate = {selectDataGenerate}");

        if (selectDataGenerate == 1)
        {
            //Создаём массивы хардкодом
            //Они уже созданы
            if (DEBUG) WriteLine($"Используем предустановленные данные");
            data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
            info = new int[] { 2, 3, 3, 1 };
            printDataAndInfoArr(data, info);
        }
        else if (selectDataGenerate == 2)
        {
            //2. Создаём массивы автоматическим рандомным от 3 до 20
            int[] sourceData = CreateArrayInt(Random.Shared.Next(3, 21));
            FillRandInt(sourceData, 0, true, 100, true);
            WriteLine($"Создаём рандомный массив из десятичных цифр:\n{PrintGood(sourceData, 1)}");
            autoDataAndInfoArrFilling(DEBUG, out data, out info, sourceData);
        }
        else if (selectDataGenerate == 3)
        {
            //3. Создать метод ручного ввода.
            int[] sourceData = new int[Input("Укажите размер массива данных:")];
            WriteLine();
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

    private static void dataAndInfoArrFilling(bool DEBUG, out int[] data, out int[] info, string sourceDataBin, string infoString)
    {
        //Заполняем массивы data и info
        data = new int[sourceDataBin.Length];
        info = new int[infoString.Length];
        for (int i = sourceDataBin.Length - 1; i >= 0; i--)
        {
            data[sourceDataBin.Length - i + 1] = sourceDataBin[i];
        }
        for (int i = infoString.Length; i >= 0; i--)
        {
            info[infoString.Length - i + 1] = infoString[i];
        }
        //Выводим на печать 
        printDataAndInfoArr(data, info);
        PrintOutResult(DEBUG, data, info);
    }
    private static void printDataAndInfoArr(int[] data, int[] info)
    {

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
        if (DEBUG) WriteLine($"Inside of autoDataAndInfoArrFilling(),\nsourceData:\n{PrintGood(sourceData, 1)}");
        //Конвертируем значения массива в двоичный код и узнаём количество символов в двоичном представлении для каждого десятичного числа
        for (int i = 0; i < sourceData.Length; i++)
        {
            restOfDeviding = sourceData[i] / 2;
            leftPartOfDeviding = sourceData[i] % 2 == 0 ? 0 : 1;
            binCounter = 1;//Показатель степени для числа в двоичном представлении, то есть элемент массива info
            while (restOfDeviding >= 2)
            {
                sourceDataBin += leftPartOfDeviding;//Создаем строку (массив) из бинарных элементов 
                binCounter++;
                restOfDeviding /=2;
            }
            infoString += binCounter;//Строка с данными по всем длинам двоичных элементов
        }
        if (DEBUG) WriteLine($"sourceDataBin = {sourceDataBin},\n infoString = {infoString}");
        //
        dataAndInfoArrFilling(DEBUG, out data, out info, sourceDataBin, infoString);
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