using static System.Console;
using System.Linq;
using System;

/// <summary>
/// Это библиотека для работы с массивами
/// <para> Метод создания одномерного массива int[] array = CreateArrayInt(arrSize) </para>
/// <para> Метод создания одномерного массива char[] array = CreateArrayChar(count) </para>
/// <para> Метод создания двумерного массива int[,] array = CreateArrayIntTwo(arrSize1, arrSize2) </para>
/// <para> Метод создания двумерного массива uint[] </para> 
/// <para> Метод создания int массива 3 dimention int[,,] array = CreateArrayInt3D(arrSize1, arrSize2, arrSize3) </para>
/// <para> Метод создания массива double[] array = CreateArrayDouble </para>
/// <para> Метод создания одномерного массива bool[] array = CreateArrayBool(arrSize)</para>
/// <para> Метод заполнения одномерного массива случайными int элементами из диапазона от min до max - FillRandInt(arrName, 10, false, 100, true)</para>
/// <para> Метод заполнения массива трёхзначными числами и подсчёта чётных и нечётных FillRand3DigitIntCheckEvenOddCount(arrName, arrCount, true) </para>
/// <para> Метод заполнения трёхмерного массива двузначными неповторяющимися целыми числами из диапазона от 10 до 99 - FillRandInt3D</para>
/// <para> Метод заполнения двумерного массива случайными int элементами из диапазона от min до max - FillRandIntTwo(arrName, 10, false, 100, true) </para>
/// <para> Метод Заполнения одномерного массива случайными числами double - FillRandDouble(arrName, 10, 0, false, 500, 100, 4, true) </para>
/// <para> Метод заполнения двумерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac - FillRandDoubleTwo(arrName, 10, 0, false, 500, 100, 4, true)   </para>
/// <para> Метод печати целочисленного массива ПЛОХОЙ PrintBad(int[] array)</para>
/// <para> Метод подготовки для печати одномерного массива !ПЛОХОЙ WriteLine(PrintGood(arrName, 4)) </para>
/// <para> Метод подготовки для печати двумерного массива !ПЛОХОЙ WriteLine(PrintGoodTwo(arrName, 4)) </para>
/// <para> Метод подготовки для печати трёхмерного массива !ПЛОХОЙ WriteLine(PrintGoodTwo(arrName, interval)) <para>
/// <para> Метод подготовки для печати трёхмерного массива !ПЛОХОЙ WriteLine(PrintGood3DInt(arrName, interval)) <para>
/// <para> Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt counter = IntervalCounter(array, minInt, minInclude, maxInt, maxInclude) </para>
/// <para> Метод для ввода целочисленного значения data = Input("Введите целое число")</para>
/// <para> Метод вычисления размерности числа через Log: для 0...9 ->1; 10...99 ->2 и так далее digits = DigitsInNumber(15) возвращает 2 </para>
/// <para> Метод удаления строки и столбца из двумерного массива MinusMinArray(array, newArray, rowCol, true)</para>
/// <para> Метод поиска минимального и максимального элемента в двумерном массиве int [] a = MinMaxInArray(array, rowColArray)</para>
/// <para> Метод подбора правильного склонения для основания системы счисления. Например, 2 -> двоичной, 8 -> восьмеричной и т.д. Например: string[] strToPrint = CountSystem(int M) </para>
/// <para> Метод заполнения входящего массива char подстрочными/надстврочными индексами (selector 0/1)). Например, ₁₀. char[] arr = CharSelector(digit, selector) </para>
/// <para> Метод преобразования входящего int параметра в подстрочный или надстрочный регистр. Например, 5 -> ₅ Write(CharSelector(digit, selector)) </para>
/// <para> Метод заполнения входящего массива char подстрочными индексами. Например, ₁₀. </para>
/// <para> Метод заполнения массива случайными целыми числами и подсчёта сумм чётных и нечётных элементов FillRandInt(arrName, 10, false, 100, true, count, DEBUG, intreval) </para>
/// <para> // Метод заполнения массива случайными вещественными числами и подсчёта разницы max - min элементов WriteLine(FillRandInt(arrName, 10, false, 100, true, counе, DEBUG, intreval)) </para>
/// <para> Метод создания одномерного массива float[] arr = CreateArrayFloat(size1_0); </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>

/// </summary>
public class MyLibrary
{

    //Основная логика частотного словаря MainCode(int[] arr, bool DEBUG)
    /// <summary> Основная логика частотного словаря MainCode(int[] arr, bool DEBUG)</summary>
    /// <param name="arr">Входящий int массив</param>
    /// <returns></returns>
    /// <example>int[] arr = CreateArrayInt(size1_0);
    public static void MainCodeFrequencyArr(int[] arr, bool DEBUG)
    {
        int[] frequencyArr = CreateArrayInt(arr.Length);//Создаём частотный массив для элементов основного массива

        //Заполнение частотного массива нолями
        PrefillOneArray(frequencyArr, DEBUG);

        //Вывод исходного массива в консоль
        WriteLine($"{PrintGood(arr, 1)}\n");

        //Сортировка массива
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] > arr[j]) arr[i] = arr[i] + arr[j] - (arr[j] = arr[i]);

        if (DEBUG) WriteLine($"\nОтсортированный массив:\n{PrintGood(arr, 1)}\n");// 
        int temp = 0;

        //Поиск частот
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != 0)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                    {
                        temp = arr[i];
                        frequencyArr[i]++;
                        arr[j] = 0;
                    }
            }
            if (DEBUG) WriteLine($"arr[{i}] = {temp} frequencyArr[{i}] = {frequencyArr[i]}");
        }
        if (DEBUG) WriteLine($"frequencyArr массив:\n{PrintGood(frequencyArr, 1)}\n");

        ///Вывод на печать
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != 0)
            {
                ChangeForegroundColor(i % 10);
                Thread.Sleep(50);
                Write(value: $"{arr[i]} встречается {frequencyArr[i]}");
                WriteLine(frequencyArr[i] % 10 == 1 | frequencyArr[i] % 10 == 5 | frequencyArr[i] % 10 == 6 | frequencyArr[i] % 10 == 7 | frequencyArr[i] % 10 == 8 % 10 | frequencyArr[i] % 10 == 9 | frequencyArr[i] % 10 == 0 ? " раз\t" : " раза\t");
                Console.ResetColor();
            }

        ForegroundColor = ConsoleColor.White;
    }

    // Метод изменения цвета консольного текста
    /// <summary>Метод изменения цвета консольного текста</summary>
    /// <param name=number">0-9 условный номер цвета массива</param>
    /// <example>ChangeForegroundColor(colorNumber);</example>
    public static void ChangeForegroundColor(int colorNumber)
    {
        switch (colorNumber)
        {
            case 0:
                ForegroundColor = ConsoleColor.Blue;
                break;
            case 1:
                ForegroundColor = ConsoleColor.Gray;
                break;
            case 2:
                ForegroundColor = ConsoleColor.Green;
                break;
            case 3:
                ForegroundColor = ConsoleColor.Cyan;
                break;

            case 4:
                ForegroundColor = ConsoleColor.Red;
                break;

            case 5:
                ForegroundColor = ConsoleColor.DarkCyan;
                break;

            case 6:
                ForegroundColor = ConsoleColor.DarkGray;
                break;

            case 7:
                ForegroundColor = ConsoleColor.Magenta;
                break;

            case 8:
                ForegroundColor = ConsoleColor.DarkYellow;
                break;

            case 9:
                ForegroundColor = ConsoleColor.White;
                break;

        }

    }



    // Метод создания одномерного массива int
    /// <summary>
    /// Метод создания одномерного массива int
    /// </summary>
    /// <param name="count">Количество элементов нового int массива</param>
    /// <returns>Созданный массив из count элементов типа int</returns>
    /// <example>int[] arr = CreateArrayInt(size1_0);
    public static int[] CreateArrayInt(int count)
    {
        return new int[count]; // new int[count];
    }

    // Метод создания одномерного массива char[]
    /// <summary>
    /// Метод создания одномерного массива char[]
    /// </summary>
    /// <param name="count">Количество элементов нового char массива</param>
    /// <returns>Созданный массив из count элементов типа char</returns>
    /// <example>char[] arr = CreateArrayChar(5);
    public static char[] CreateArrayChar(int count)
    {
        return new char[count]; // new int[count];
    }

    // Метод создания двумерного массива int[,]
    /// <summary>
    /// Метод создания двумерного массива int
    /// </summary>
    /// <param name="N">Количество строк нового int массива</param>
    /// <param name="М">Количество столбцов нового int массива</param>
    /// <returns>Созданный массив из [N, M] элементов типа int</returns>
    public static int[,] CreateArrayIntTwo(int N, int M)
    {
        return new int[N, M]; // new int[N, M];
    }

    // Метод создания двумерного массива uint[]
    /// <summary> Метод создания двумерного массива uint </summary>
    /// <param name="N">Количество строк нового int массива</param>
    /// <param name="М">Количество столбцов нового int массива</param>
    /// <returns>Созданный массив из [N, M] элементов типа int</returns>
    public static uint[] CreateArrayUint(int N)
    {
        return new uint[N]; // new uint[N];
    }

    // Метод создания int массива 3 dimention CreateArrayInt3D
    /// <summary>
    /// Метод создания int массива 3 dimention CreateArrayInt3D
    /// </summary>
    /// <param name="K, M, N">Размерность нового массива</param>
    /// <returns>Созданный массив из [K, M, N] элементов типа int</returns>
    /// <example> int[,,] arr = CreateArrayInt3D(K, M, N) <example>
    public static int[,,] CreateArrayInt3D(int K, int M, int N)
    {
        return new int[K, M, N];
    }

    // Метод создания одномерного массива double
    /// <summary> Метод создания одномерного массива double </summary>
    /// <param name="count">Количество элементов нового double массива</param>
    /// <returns>Созданный массив из count элементов типа double</returns>
    /// <example> double[] arr = CreateArrayDouble(count) </example>
    public static double[] CreateArrayDouble(int count)
    {
        return new double[count]; // new double[count];
    }

    // Метод создания массива bool
    /// <summary> Метод создания массива bool </summary>
    /// <param name="count">Количество элементов нового bool массива</param>
    /// <returns>Созданный массив из count элементов типа bool</returns>
    /// <example> bool[] array = CreateArrayBool(count)
    public static bool[] CreateArrayBool(int count)
    {
        return new bool[count]; // new bool[count];
    }

    // Метод заполнения одномерного массива случайными int элементами из диапазона от min до max
    /// <summary> Метод заполнения одномерного массива случайными int элементами из диапазона от min до max </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <example> Пример вызова метода: FillRandInt(arrName, 10, false, 100, true) </example>
    public static void FillRandInt(int[] array, int min, bool minInclude, int max, bool maxInclude)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1);
        }
    }

    // Метод заполнения массива трёхзначными числами и подсчёта чётных и нечётных FillRand3DigitIntCheckEvenOddCount(arrName, arrCount, true)
    /// <summary> Метод заполнения массива трёхзначными числами и подсчёта чётных и нечётных FillRand3DigitIntCheckEvenOddCount(arrName, arrCount, true) </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="count">Массив из двух индексов в который кладём количество чётных и нечётных значений исходного массива</param>
    /// <param name="DEBUG">Флаг  вывода отладочной информации</param>
    /// <example> Пример вызова метода: FillRand3DigitIntCheckEvenOddCount(arrName, arrCount, true) </example>
    public static void FillRand3DigitIntCheckEvenOddCount(int[] array, int[] count, bool DEBUG)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(100, 1000);
            if (array[i] % 2 == 0)
            { count[0]++; }
            else
            { count[1]++; };
        }
        if (DEBUG) WriteLine($"MyLib Line 138 {count[0]} {count[1]}");
    }

    // Метод заполнения трёхмерного массива двузначными неповторяющимися целыми числами из диапазона от 10 до 99
    /// <summary> Метод заполнения трёхмерного массива неповторяющимися двузначными целыми числами из диапазона от 10 до 99 </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// Пример вызова метода: FillRandInt3D(arrName)
    public static void FillRandInt3D(int[,,] array)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        int size2 = array.GetLength(2);
        int filler = 10;
        for (int k = 0; k < size0; k++)
        {
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    array[k, i, j] = filler;
                    filler++;
                }
            }
        }
    }

    // Метод заполнения двумерного массива случайными int элементами из диапазона от min до max
    /// <summary> Метод заполнения двумерного массива случайными int элементами из диапазона от min до max </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <example> Пример вызова метода: FillRandIntTwo(arrName, 10, false, 100, true) </example>
    public static void FillRandIntTwo(int[,] array, int min, bool minInclude, int max, bool maxInclude)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        for (int i = 0; i < size0; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                array[i, j] = Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1);
                //array[i] = new Random().Next(min, max);
            }

        }
    }

    // Метод заполнения одномерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac
    /// <summary> Метод заполнения одномерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="minInt">Минимальное значение целой части для заполнения случайными элементами</param>
    /// <param name="minFrac">Минимальное значение дробной части для заполнения случайными элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение minInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="maxInt">Максимальное значение целой части для заполнения случайными элементами</param>
    /// <param name="maxFrac">Максимальное значение дробной части для заполнения случайными элементами</param>
    /// <param name="numOfDigits">Разрядность дробной части для заполнения случайными элементами - показатель степени 10 - числа, на которое нужно делить рандомную часть 4 означает 10^4 = 10000</param> 
    /// <param name="maxInclude">Включает ли максиимальное граничное значение maxInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <example> Пример вызова метода: FillRandDouble(arrName, 10, 0, false, 500, 100, 4, true) </example> 
    public static void FillRandDouble(double[] array, int minInt, int minFrac, bool minInclude, int maxInt, int maxFrac, int numOfDigits, bool maxInclude)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(minInclude ? minInt : minInt - 1, maxInclude ? maxInt : maxInt - 1) + (Random.Shared.Next(minFrac, maxFrac) / (Math.Pow(10, numOfDigits)));
        }
    }

    // Метод заполнения двумерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac
    /// <summary> Метод заполнения двумерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="minInt">Минимальное значение целой части для заполнения случайными элементами</param>
    /// <param name="minFrac">Минимальное значение дробной части для заполнения случайными элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение minInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="maxInt">Максимальное значение целой части для заполнения случайными элементами</param>
    /// <param name="maxFrac">Максимальное значение дробной части для заполнения случайными элементами</param>
    /// <param name="numOfDigits">Разрядность дробной части для заполнения случайными элементами - показатель степени 10 - числа, на которое нужно делить рандомную часть 4 означает 10^4 = 10000</param> 
    /// <param name="maxInclude">Включает ли максиимальное граничное значение maxInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <example> Пример вызова метода: FillRandDoubleTwo(arrName, 10, 0, false, 500, 100, 4, true) </example> 
    public static void FillRandDoubleTwo(double[,] array, int minInt, int minFrac, bool minInclude, int maxInt, int maxFrac, int numOfDigits, bool maxInclude)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        for (int i = 0; i < size0; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                array[i, j] = Random.Shared.Next(minInclude ? minInt : minInt - 1, maxInclude ? maxInt : maxInt - 1) + (Random.Shared.Next(minFrac, maxFrac) / (Math.Pow(10, numOfDigits)));
                //array[i] = new Random().Next(min, max);
            }
        }
    }

    // Метод печати целочисленного массива ПЛОХОЙ PrintBad(int[] array)
    /// <summary> Метод печати массив ПЛОХОЙ PrintBad(int[] array) </summary>
    /// <param name="array">Массив, который нужно вывести на экран через консоль</param>
    /// <example> Пример вызова метода: PrintBad(array) </example> 
    public static void PrintBad(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            WriteLine($"{array[i],3}");//Если придётся писать данные в файл или БД, то метод работать не будет
        }
        WriteLine();
    }

    // Метод подготовки для печати одномерного массива !ПЛОХОЙ WriteLine(PrintGood(arrName, 4))
    /// <summary> Метод подготовки переменной типа string для печати. Элементы имеют отступы interval пунктов. </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// <example> Пример вызова метода: WriteLine(PrintGood(arrName, 4)) </example> 
    public static string PrintGood(int[] array, int interval)
    {
        string output = String.Empty; //Создали пустую строку
        int size = array.Length;

        for (int i = 0; i < size; i++)
        {
            if (i % 10 == 0) output += $"\n";
            output += $"{array[i]}{string.Concat(Enumerable.Repeat("\t", interval))}";
        }
        return output;
    }

    // Метод подготовки для печати двумерного массива !ПЛОХОЙ WriteLine(PrintGoodTwo(arrName, 4))
    /// <summary> Метод подготовки переменной типа string для печати. Элементы имеют размерность interval пунктов. </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// <example> Пример вызова метода: WriteLine(PrintGood(arrName, 4)) </example> 
    public static string PrintGoodTwo(int[,] array, int interval)
    {
        string output = String.Empty; //Создали пустую строку
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        for (int i = 0; i < size0; i++)
        {
            for (int j = 0; j < size1; j++)
                output += $"{array[i, j]}{string.Concat(Enumerable.Repeat("\t", interval))}";
            output += "\n";
        }
        return output;
    }

    // Метод подготовки для печати трёхмерного массива !ПЛОХОЙ WriteLine(PrintGood3DInt(arrName, interval))
    /// <summary>
    /// Метод подготовки переменной типа string для печати. Элементы имеют размерность \t * interval пунктов.
    /// </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// <example> Пример вызова метода: PrintGood3DInt(arrName, interval) </example>
    public static string PrintGood3DInt(int[,,] array, int interval)
    {
        string output = String.Empty; //Создали пустую строку
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        int size2 = array.GetLength(2);
        for (int k = 0; k < size0; k++)
        {
            for (int i = 0; i < size1; i++)
                for (int j = 0; j < size2; j++)
                    output += $"array[{k}, {i}, {j}] = {array[k, i, j]}{string.Concat(Enumerable.Repeat("\t", interval))}";
            output += "\n";
            output += "\n\n";
        }
        return output;
    }

    // Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt counter = IntervalCounter(array, minInt, minInclude, maxInt, maxInclude)
    /// <summary> Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt </para>
    /// <param name="array">Массив для проверки</param>
    /// <param name="minInt">Нижняя граница диапазона проверки</param>
    /// <param name="minInclude">Включается ли граничное значение в диапазон сравнения</param>
    /// <param name="maxInt">Верхняя граница диапазона проверки</param>
    /// <param name="maxInclude">Включается ли граничное значение в диапазон сравнения</param>
    /// <returns>Количество элементов в диапазоне от minInt до maxInt</returns>
    /// <example> counter =  IntervalCounter(array, minInt, minInclude, maxInt, maxInclude) </example>
    public static int IntervalCounter(int[] array, int minInt, bool minInclude, int maxInt, bool maxInclude)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if (array[i] >= (minInclude ? minInt : minInt + 1) && array[i] <= (maxInclude ? maxInt : maxInt - 1))
            {
                result++;
            }
        }
        return result;
    }

    // Метод для ввода целочисленного значения data = Input("Введите целое число")
    /// <summary> Метод для ввода целочисленного значения </summary>
    /// <param name="text">Текст пояснения для пользователя - что он должен ввести</param>
    /// <returns>Введенное пользователем значение</returns>
    public static int Input(string text)
    {
        OutputDynamicString(text);
        return int.Parse(ReadLine());
    }

    // Метод для вывода бегущей строкой
    /// <summary> Метод для вывода бегущей строкой </summary>
    /// <param name="text">Текст который нужно вывести в консоль</param>
    public static void OutputDynamicString(string text)
    {
        ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < text.Length; i++)
        {
            Thread.Sleep(50);
            Write(text[i]);
            if (!OperatingSystem.IsMacOS()) Beep(Random.Shared.Next(37, 32767), 100);
        }
        Console.ResetColor();
    }

    // Метод для ввода целочисленного значения Select()
    /// <summary> Метод для ввода целочисленного значения </summary>
    /// <param name="text">Текст пояснения для пользователя - что он должен ввести</param>
    /// <returns>Введенное пользователем значение</returns>
    public static string Select(string text, int saveCursorSize)
    {
        OutputDynamicString(text);
        if (!OperatingSystem.IsMacOS()) Console.CursorSize = 100;
        return ReadLine();
    }

    //Метод вычисления размерности int числа через Log: для 0...9 ->1; 10...99 ->2 и так далее digits = DigitsInNumber(15) возвращает 2
    /// <summary> Метод вычисления размерности числа через Log: для 0...9 ->1; 10...99 ->2 и так далее </summary>
    /// <param name="number">Входное число типа int</param>
    /// <returns>Количество цифр во вкодном числе</returns>
    /// <example> digits = DigitsInNumber(15) возвращает 2 </example>
    public static int DigitsInNumber(int number)
    {
        return (int)Math.Log(number, 10) + 1;
    }


    // Метод удаления строки и столбца из двумерного массива MinusMinArray(array, newArray, rowCol, true)
    /// <summary>
    /// Метод удаления строки и столбца из двумерного массива
    /// </summary>
    /// <param name="array">Массив, из которого удаляем строку и столбец</param>
    /// <param name="rowCol[0]">Номер исключаемой строки</param>
    /// <param name="rowCol[1]">Номер исключаемого столбца</param> 
    /// <param name="newArray">Новый массив с исключенными строкой и столбцом</param> 
    /// <param name="DEBUG">Определяем режим отладки или прода. Если значение DEBUG = <see langword="true"/>, то выводим специнфомацию</param> 
    /// <returns>Возвращаем уменьшенный массив</returns>
    /// Пример вызова метода: MinusMinArray(array, newArray, rowCol, true)
    public static int[,] MinusMinArray(int[,] array, int[,] newArray, int[] rowCol, bool DEBUG)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        int[,] temp = new int[size0 - 1, size1];
        //1
        for (int i = 0; i < rowCol[0]; i++)
        {
            for (int j = 0; j < size1; j++)
            {
                temp[i, j] = array[i, j];
            }
        }
        //2
        for (int i = rowCol[0]; i < size0 - 1; i++)
            for (int j = 0; j < size1; j++)
            {
                temp[i, j] = array[i + 1, j];
            }
        //3
        for (int i = 0; i < size0 - 1; i++)
        {
            for (int j = 0; j < rowCol[1]; j++)
            {
                newArray[i, j] = temp[i, j];
            }
            for (int j = rowCol[1]; j < size1 - 1; j++)
            {
                if (DEBUG) WriteLine($"i = {i}, j = {j}");
                newArray[i, j] = temp[i, j + 1];
            }
        }
        //4

        return newArray;
    }

    // Метод поиска минимального и максимального элемента в двумерном массиве int [] a = MinMaxInArray(array, rowColArray)
    /// <summary> Метод поиска минимального и максимального элемента в двумерном массиве </summary>
    /// <param name="array">Массив, в котором ищем элемент</param>
    /// <param name="rowCol[0]">Номер исключаемой строки</param>
    /// <param name="rowCol[1]">Номер исключаемого столбца</param> 
    /// Пример вызова метода: MinInArray(array, rowColArray, 2)
    public static int[] MinMaxInArray(int[,] array, int[] rowCol)
    {
        int size0 = array.GetLength(0);
        int size1 = array.GetLength(1);
        int min = array[0, 0];
        for (int i = 0; i < size0; i++)
            for (int j = 0; j < size1; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    rowCol[0] = i;
                    rowCol[1] = j;
                }
            }
        return rowCol;
    }

    // Метод подбора правильного склонения для основания системы счисления. Например, 2 -> двоичной, 8 -> восьмеричной и т.д.
    /// <summary> Метод подбора правильного склонения для основания системы счисления. Например, 2 -> двоичной, 8 -> восьмеричной и т.д. </summary>
    /// <param name="M">Основание системы счисления</param>
    /// <returns> Строка с правильным текстом </returns>
    /// Пример вызова метода: MinInArray(array, 5, 2)
    public static string CountSystem(int M)
    {
        switch (M)
        {
            case 2:
                return "двоичной";
                break;
            case 3:
                return "троичной";
                break;

            case 4:
                return "четверичной";
                break;

            case 5:
                return "пятеричной";
                break;

            case 6:
                return "шестиричной";
                break;

            case 7:
                return "семиричной";
                break;

            case 8:
                return "восьмеричной";
                break;

            case 9:
                return "девятиричной";
                break;

            case 10:
                return "десятичной";
                break;

            case 11:
                return "одиннадцатириричной";
                break;

            case 12:
                return "двеннадцатиричной";
                break;

            case 13:
                return "триннадцатиричной";
                break;

            case 14:
                return "четырнадцатиричной";
                break;

            case 15:
                return "пятнадцатиричной";
                break;

            case 16:
                return "шестнадцатиричной";
                break;

            case 17:
                return "семнадцатиричной";
                break;

            case 18:
                return "восемнадцатиричной";
                break;

            case 19:
                return "девятнадцатиричной";
                break;

            case 20:
                return "двадцатиричной";
                break;

            default:
                return M.ToString();

                break;
        };
    }

    // Метод преобразования входящего int параметра в подстрочный или надстрочный регистр. Например, 5 -> ₅ Write(CharSelector(digit, selector))
    /// <summary> Метод преобразования входящего параметра в подстрочный или надстрочный регистр. Например, 5 -> ₅. </summary>
    /// <param name="digit">Число, которое нужно перевести в подстрочный регистр</param>
    /// <param name="selector">Настройка режима 0 - нижний регистр, 1 - верхний регистр</param>
    /// <returns> Unicode символ типа char, соответствующий входящей цифре, в нужном регистре </returns>
    /// <example> Пример вызова метода: Write(CharSelector(digit, selector)) <example>
    ///Output ₅
    public static char CharSelector(int digit, int selector)
    {
        //selector = 0 - подстрочный индекс
        //selector = 1 - надстрочный индекс
        //Подробнее по кодам здесь: https://wiki5.ru/wiki/Unicode_subscripts_and_superscripts
        if (selector == 0)
        {
            switch (digit)
            {
                case 0:
                    return '\u2080';
                case 1:
                    return '\u2081';
                case 2:
                    return '\u2082';
                case 3:
                    return '\u2083';
                case 4:
                    return '\u2084';
                case 5:
                    return '\u2085';
                case 6:
                    return '\u2086';
                case 7:
                    return '\u2087';
                case 8:
                    return '\u2088';
                case 9:
                    return '\u2089';

                default:
                    return (char)('\x208' + digit);
            }
        }
        else if (selector == 1)
        {
            switch (digit)
            {
                case 0:
                    return '\u2070';
                case 1:
                    return '\u2071';
                case 2:
                    return '\u00B2';
                case 3:
                    return '\u00B3';
                case 4:
                    return '\u2074';
                case 5:
                    return '\u2075';
                case 6:
                    return '\u2076';
                case 7:
                    return '\u2077';
                case 8:
                    return '\u2078';
                case 9:
                    return '\u2079';

                default:
                    return (char)('\x208' + digit);
            }
        }
        else return '0';
    }

    // Метод заполнения входящего массива char подстрочными индексами. Например, ₁₀.
    /// <summary>
    /// Метод заполнения входящего массива char подстрочными индексами. Например, ₁₀.
    /// </summary>
    /// <param name="digit">Число, которое нужно перевести в подстрочный регистр</param>
    /// <param name="selector">Настройка режима 0 - нижний регистр, 1 - верхний регистр</param>
    /// <returns> Unicode символ типа char, соответствующий входящей цифре, в нужном регистре </returns>
    /// <example> Пример вызова метода: MinInArray(5, 0) </example> 
    ///Output ₅
    public static char[] FillArrWithDimension(char[] os, int osBase)
    {
        string osBaseLocal = osBase.ToString();
        Array.Clear(os, 0, os.Length);
        for (int i = 0; i < os.Length; i++)
        {
            os[i] = CharSelector((int)Char.GetNumericValue(osBaseLocal[i]), 0);//Конвертировали основние системы счисления через Unicode в подстрочный индекс
        }
        return os;
    }

    // Метод заполнения массива случайными целыми числами и подсчёта сумм чётных и нечётных элементов FillRandInt(arrName, 10, false, 100, true, count, DEBUG, intreval)
    /// <summary> Метод заполнения одномерного массива случайными int элементами из диапазона от min до max </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <param name="count">Массив для вывода суммы чётных и нечётных элементов массива array</param> 
    /// <param name="DEBUG">Указатель режима отладки <see langword="false"/>  или рабочего <see langword="true"/> </param> 
    /// <example> Пример вызова метода: FillRandInt(arrName, 10, false, 100, true, count, DEBUG, intreval) </example> 
    public static string FillRandIntSum(int[] array, int min, bool minInclude, int max, bool maxInclude, int[] count, bool DEBUG, int interval)
    {
        string output = string.Empty;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1);
            output += $"{array[i]}{string.Concat(Enumerable.Repeat("\t", interval))}";
            if (i % 2 == 0)
            { count[0] += array[i]; }
            else
            { count[1] += array[i]; }
        }
        output += "\n";
        return output;
    }

    // Метод заполнения массива случайными вещественными числами и подсчёта разницы max - min элементов WriteLine(FillRandInt(arrName, 10, false, 100, true, counе, DEBUG, intreval))
    /// <summary> Метод заполнения массива случайными вещественными числами и подсчёта разницы max - min элементов </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <param name="count">Массив для вывода min max элементов массива array</param> 
    /// <example> Пример вызова метода: FillRandInt(arrName, 10, false, 100, true, counе, DEBUG, intreval) </example> 
    public static string FillRandFloatDiff(float[] array, int min, bool minInclude, int max, bool maxInclude, float[] count, bool DEBUG, int interval)
    {
        string output = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (float)Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1) / 10000 + Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1);

            output += $"{array[i]}{string.Concat(Enumerable.Repeat("\t", interval))}";
            if (i == 0) count[0] = count[1] = array[i];
            else if (array[i] > count[1]) count[1] = array[i];
            else if (array[i] < count[0]) count[0] = array[i];
        }
        output += "\n";
        return output;
    }

    // Метод создания одномерного массива float float[] arr = CreateArrayFloat(size1_0);
    /// <summary> Метод создания одномерного массива float </summary>
    /// <param name="count">Количество элементов нового int массива</param>
    /// <returns>Созданный массив из count элементов типа int</returns>
    /// <example>float[] arr = CreateArrayFloat(size1_0);
    public static float[] CreateArrayFloat(int count)
    {
        return new float[count];
    }

    // Метод подготовки для вывода на печать массива Write(OutputArrByJoin(array, 1));
    /// <summary> Метод создания одномерного массива float </summary>
    /// <param name="array">Исходный массив данных, которые нужно вывести</param>
    /// <param name="interval">Количество табуляторов между элементами при выводе</param>
    /// <returns>Строка с нужной разметкой</returns>
    /// <example>Write(OutputArrByJoin(array, 1));
    public static string OutputArrByJoin(int array, int interval)
    {
        return string.Join(string.Concat(Enumerable.Repeat("\t", interval)), array);
    }

    // Метод заполнения двумерного массива int элементами пирамиды Паскаля
    /// <summary> Метод заполнения двумерного массива размерности в ширину консоли int элементами пирамиды Паскаля </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="interval">Количество табуляторов между элементами при выводе</param>  
    /// <param name="curr_line_number">Порядновый номер строки пирамиды Паскаля. Нумерация начинается с 1</param>  
    /// <example> Пример вызова метода: FillPascalTriangle(array, interval) </example>
    public static string FillPascalTriangle(uint[] array, int interval, int curr_line_number, bool DEBUG)
    {
        string output = String.Empty;
        int size0 = array.Length, digInNumber;

        //Вычисляем сдвиг - количество элементов на которые нужно сдвинуть при выводе на печать от левого края консоли
        int locOffset = size0 / 2 - curr_line_number + 2;//ПЕРЕПОЛНЕНИЕ!!! ***************************

        //Сдвигаем элементы массива вправо на один
        for (int i = size0 - 1; i <= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = 0;//Добавили первым элементом ноль

        //Делаем разный первоначальный сдвиг в зависимости от того, чётная или нечётная строка. Потому, что их нужно сдвигать на пол элемента. Сохраняем сдвиг.
        string intervalOfsetString = ConcatLocal(" ", interval / 2, DEBUG);//Задали шаг между элементами
        string even_ofset = ConcatLocal(intervalOfsetString, locOffset, DEBUG) + ConcatLocal(" ", interval / 2, DEBUG);
        string odd_ofset = ConcatLocal(intervalOfsetString, locOffset + 1, DEBUG);// + ConcatLocal(" ", interval * 3 / 2, DEBUG);
        output = (curr_line_number % 2 == 0) ? even_ofset : odd_ofset;
        Write(output);
        if (DEBUG)
        {
            Write($"curr_line_number = {curr_line_number} ");
            Write($"even_ofset = {even_ofset.Length} ");
            Write($"odd_ofset = {odd_ofset.Length} ");
            Write((curr_line_number % 2 == 0) ? "use even_ofset " : "use odd_ofset ");
            Write($"locOffset {locOffset} ");
            WriteLine($"output.Length {output.Length} ");
        }
        //Заполняем массив ненулевыми элементами

        for (int i = locOffset + 1; i < size0 / 2 + 1; i++)
        {
            //Чтобы найти следующую строку в треугольнике, нужно взять предыдущую, и прибавить к ней точно такую же, но сдвинутую на одну колонку вправо.
            //http://mech.math.msu.su/~shvetz/54/inf/perl-examples/PerlExamples_PascalTriangle_Ideas.xhtml
            array[i] += array[i + 1];
            digInNumber = array[i].ToString().Length;
            if (DEBUG) WriteLine($"digInNumber = {digInNumber} ");// 

            ChangeForegroundColor((int)array[i] % 10);
            Write($"{ConcatLocal(" ", interval - digInNumber, DEBUG)}{array[i]}");
            //output += $"{ConcatLocal(" ", interval - digInNumber, DEBUG)}{array[i]}";// : $"{intervalOfsetString}";//Если элемент массива не равен нолю, выводим его, если равен - выводим количество символов максимального элемента
            Console.ResetColor();
            //output += " ";//string.Concat(Enumerable.Repeat(" ", interval));
        }
        //output += "\n";
        return output;
    }

    // Метод заполнения одномерного массива int нолями
    /// <summary> Метод заполнения одномерного массива int элементами = 0 </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="interval">Количество табуляторов между элементами при выводе</param>    
    /// <example> Пример вызова метода: PrefillArray(array, interval) </example>
    public static void PrefillArray(uint[] array, int interval, bool DEBUG)
    {
        if (DEBUG) WriteLine("PrefillArray fill");
        int size0 = array.Length, locOfset = size0 / 2;
        for (int i = 0; i < size0; i++)
        {
            array[i] = 0;
        }
        array[locOfset] = 1;
        if (DEBUG) WriteLine($"Отступ = locOfset * interval = {locOfset * interval}");
    }

    // Метод заполнения одномерного массива int нолями
    /// <summary> Метод заполнения одномерного массива int элементами = 0 </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="interval">Количество табуляторов между элементами при выводе</param>    
    /// <example> Пример вызова метода: PrefillArray(array, interval) </example>
    public static void PrefillArray(int[] array, int interval, bool DEBUG)
    {
        if (DEBUG) WriteLine("PrefillArray fill");
        int size0 = array.Length, locOfset = size0 / 2;
        for (int i = 0; i < size0; i++)
        {
            array[i] = 0;
        }
        array[locOfset] = 1;
        if (DEBUG) WriteLine($"Отступ = locOfset * interval = {locOfset * interval}");
    }

    // Метод заполнения одномерного массива int нолями
    /// <summary> Метод заполнения одномерного массива int элементами = 0 </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="interval">Количество табуляторов между элементами при выводе</param>    
    /// <example> Пример вызова метода: PrefillArray(array, interval) </example>
    public static void PrefillZeroArray(int[] array, bool DEBUG)
    {
        if (DEBUG) WriteLine("PrefillZeroArray filling start");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
            if (DEBUG) WriteLine($"array[{i}] = {array[i]}");
        }
        if (DEBUG) WriteLine($"PrefillZeroArray filling complete");
    }

    // Метод заполнения одномерного массива int единицами
    /// <summary> Метод заполнения одномерного массива int элементами = 0 </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <example> Пример вызова метода: PrefillArray(array, interval) </example>
    public static void PrefillOneArray(int[] array, bool DEBUG)
    {
        if (DEBUG) WriteLine("PrefillOneArray filling start");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 1;
            if (DEBUG) WriteLine($"array[{i}] = {array[i]}");
        }
        if (DEBUG) WriteLine($"PrefillOneArray filling complete");
    }

    // Метод вычисления факториала
    /// <summary> Метод вычисления факториала </summary>
    /// <param name="argument">Массив, который заполняем</param>
    /// <example> Пример вызова метода: FillPascalTriangle(array, interval) </example>
    public static uint Factorial(int argument, bool DEBUG)
    {
        uint factorial = 1;
        if (argument >= 1)
        {
            for (uint i = 1; i <= argument; i++)
            {
                factorial *= i;
                if (DEBUG) WriteLine($"Факториал = {factorial}");
            }
        }
        return factorial;
    }

    // Альтернативный Input
    /// <summary> Альтернативный метод ввода int данных с обработкой ошибки ввода </summary>
    /// <param name="err_msg">Текст сообщения, если пользователь ввёл не целое положительное число</param>
    /// <param name="msg">Текст сообщения, что необходимо сделать пользователю</param>
    /// <param name="DEBUG">Флаг режима компиляции 1 = отладка с выводом логов, 0 - без вывода логов</param>
    /// <example> Пример вызова метода: Input (err_msg, msg, DEBUG) </example>
    public static int Input(string err_msg, string msg, bool DEBUG)
    {
        return ConsoleHelper.ReadNumber(msg, x => x > 0, err_msg);//x>0 - условие
    }

    // Конкатенация строки
    /// <summary> Метод ввода данных </summary>
    /// <param name="msg">Строковый параметр, который нужно повторно вклеить в строку repeater раз </param>
    /// <param name="repeater">Параметр количества повторов</param>
    /// <param name="DEBUG">Флаг режима компиляции 1 = отладка с выводом логов, 0 - без вывода логов</param>
    /// <example> Пример вызова метода: ConcatLocal ("Привет! ", 5, true) </example>
    /// <example> Пример вызова метода: ConcatLocal (msg, repeater, DEBUG) </example>
    public static string ConcatLocal(string msg, int repeater, bool DEBUG)
    {
        if (repeater > 0)
        {
            return string.Concat(Enumerable.Repeat(msg, repeater));
        }
        else
        {
            return "repeater < 0 Alarm!\n";
        }
    }

}