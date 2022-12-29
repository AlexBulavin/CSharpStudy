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
            selectDataGenerate = Input($"Выберите способ создания массива данных:\n1 - предустановленный;\n2 - автоматическим рандомным от 3 до 20;\n3 - вручную;\n");
        if (DEBUG) WriteLine($"selectDataGenerate = {selectDataGenerate}");

        if (selectDataGenerate == 1)
        {
            //Создаём массивы хардкодом
            //Они уже созданы
            if (DEBUG) WriteLine($"Используем предустановленные данные");
            data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
            info = new int[] { 2, 3, 3, 1 };
            /*выходные данные:
            1, 7, 0, 1*/
            printDataAndInfoArr(data, info);
            PrintOutResult(DEBUG, data, info);
        }
        else if (selectDataGenerate == 2)
        {
            //2. Создаём массивы автоматическим рандомным от 3 до 20
            int[] sourceData = CreateArrayInt(Random.Shared.Next(3, 21));
            FillRandInt(sourceData, 0, true, 100, true);//sourceData - массив исходных десятичных данных
            WriteLine($"Создаём рандомный массив из десятичных цифр:\n{PrintGood(sourceData, 1)}\n");
            autoDataAndInfoArrFilling(DEBUG, out data, out info, sourceData);//Заполняем массивы data и info
            PrintOutResult(DEBUG, data, info);
        }
        else if (selectDataGenerate == 3)
        {
            //3. Создать метод ручного ввода.
            int[] sourceData = new int[Input("Укажите размер массива данных:")];
            WriteLine();
            for (int i = 0; i < sourceData.Length; i++) sourceData[i] = Input($"sourceData[{i}] = ");
            autoDataAndInfoArrFilling(DEBUG, out data, out info, sourceData);
            PrintOutResult(DEBUG, data, info);
        }

        //Выводим получившиеся данные через цикл //рекурсию.
        //PrintOutResult(DEBUG, ref shift, ref result, ref exponent, out data, out info);

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
        string output = String.Empty;
        string[] outputArray = new string[info.Length];
        for (int i = 0; i < info.Length; i++)
        {
            for (int j = shift; j < info[i] + shift; j++)
            {
                exponent = info[i] - 1 - (j - shift);//Ищем показатель степени в двоичной системе счисления
                if (DEBUG)
                {
                    WriteLine($"Before result incremented\ti = {i}, info[i] = {info[i]}, shift = {shift}, result = {result}, j = {j}, exponent = {exponent}");
                }
                result += data[j] * (int)Math.Pow(2, exponent);//Строим очередной элемент массива уже в десятичной системе счисления
                if (DEBUG)
                {
                    WriteLine($"After result incremented\ti = {i}, info[i] = {info[i]}, shift = {shift}, result = {result}, j = {j}, data[j] = {data[j]}, info[i] - j - shift - 1 = {info[i] - j - shift - 1}\n");
                }
                output += $"{data[j]}*2{CharSelector(exponent < 10 ? exponent : 9, 1, false)}{(exponent > 0 ? (" + ") : (" = "))}{(exponent > 0 ? ("") : ($"{result}\t\t"))}";
            };
            outputArray[i] = output;
            output = String.Empty;
            shift += info[i];
            result = 0;
        }
        WriteLine(string.Join(string.Concat(Enumerable.Repeat("\t", 1)), outputArray));
    }

    private static void dataAndInfoArrFilling(bool DEBUG, out int[] data, out int[] info, string sourceDataBin, string infoString)
    {
        //Заполняем массивы data и info
        if (DEBUG) WriteLine($"line 110 sourceDataBin = {sourceDataBin}");
        data = new int[sourceDataBin.Length];
        info = new int[infoString.Length];
        sourceDataBin = Reverse(sourceDataBin);
        /*
        for (int n = 0; n < sourceDataBin.Length; n++)
        {
            data[n] = (int)Char.GetNumericValue(sourceDataBin[n]);//[sourceDataBin.Length - n - 1]);
            // Write($"sourceDataBin[localCounter + infoStringN - i] = {sourceDataBin[localCounter + infoStringN - i]}\tdata[{i}] = {data[i]}\t");
        }
        for (int i = 0; i < infoString.Length; i++)
        {
            info[i] = (int)Char.GetNumericValue(infoString[i]);//[infoString.Length - i - 1]);
        }
        */
        int position = 0, m = 0;
        for (int i = 0; i < infoString.Length; i++)
        {
            info[i] = (int)Char.GetNumericValue(infoString[i]);
            for (int n = info[i] - 1; n >= 0; n--)
            {
                data[position + info[i] - n - 1] = (int)Char.GetNumericValue(sourceDataBin[sourceDataBin.Length - position - info[i] + m]); //sourceDataBin.Length - n - 1]);
                m++;
            }
            position += info[i];
            m = 0;
        }
        //Выводим на печать 
        printDataAndInfoArr(data, info);
        //PrintOutResult(DEBUG, data, info);
    }
    private static void printDataAndInfoArr(int[] data, int[] info)
    {

        //Печатаем исходные массивы 
        WriteLine($"data array: ");
        //SetCursorPosition(15, 8);
        WriteLine(PrintGood(data, 1));

        WriteLine($"info array: ");
        //SetCursorPosition(15, 9);
        WriteLine(PrintGood(info, 1));
        WriteLine();
    }

    private static void autoDataAndInfoArrFilling(bool DEBUG, out int[] data, out int[] info, int[] sourceData) //sourceData - массив исходных данных в десятичном представлении
    {
        string sourceDataBin = String.Empty;
        string infoString = String.Empty;
        string sourceDataBinLocal = String.Empty;
        int binCounter;
        int restOfDividing, leftPartOfDividing;//restOfDividing - остаток от деления числа нацело на 2; leftPartOfDividing - целая часть от % деления числа на 2 
        if (DEBUG) WriteLine($"Inside of autoDataAndInfoArrFilling(),\nsourceData:\n{PrintGood(sourceData, 1)}");
        //Конвертируем значения массива в двоичный код и узнаём количество символов в двоичном представлении для каждого десятичного числа
        for (int i = 0; i < sourceData.Length; i++)
        {
            if (DEBUG) WriteLine($"sourceData[{i}] = {sourceData[i]} ");//
            restOfDividing = sourceData[i] / 2; //Идём по исходному массиву, извлекаем из него элементы
            leftPartOfDividing = sourceData[i] % 2;// == 0 ? 0 : 1;
            binCounter = 1;//Показатель степени для числа в двоичном представлении, то есть элемент массива info
            if (DEBUG) WriteLine($"restOfDividing = {restOfDividing}\tleftPartOfDividing = {leftPartOfDividing}\tbinCounter = {binCounter}");// if(DEBUG)
            while (restOfDividing >= 2)
            {
                sourceDataBinLocal += leftPartOfDividing.ToString();//Создаем строку (массив) из бинарных элементов
                binCounter++;
                leftPartOfDividing = restOfDividing % 2;
                restOfDividing /= 2;

            }
            sourceDataBinLocal += leftPartOfDividing;
            sourceDataBinLocal += restOfDividing;
            if (DEBUG) WriteLine($"163 line sourceDataBinLocal = {sourceDataBinLocal}");
            sourceDataBin += sourceDataBinLocal;
            infoString += binCounter + 1;//Строка с данными по всем длинам двоичных элементов

            sourceDataBinLocal = String.Empty;
        }

        if (DEBUG) WriteLine($"173 line sourceDataBin = {sourceDataBin}\ninfoString = {infoString}");//if (DEBUG)if (DEBUG) 
        dataAndInfoArrFilling(DEBUG, out data, out info, sourceDataBin, infoString);
    }

    private static string Reverse(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
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