using static System.Console;
using System.Linq;

/// <summary>
/// Это библиотека для работы с массивами
/// <para> Метод создания одномерного массива int[] array = CreateArrayInt(arrSize) </para>
/// <para> Метод создания одномерного массива char[] array = CreateArrayChar(count) </para>
/// <para> Метод создания двумерного массива int[,] array = CreateArrayIntTwo(arrSize1, arrSize2) </para>
/// <para> Метод создания int массива 3 dimention int[,,] array = CreateArrayInt3D(arrSize1, arrSize2, arrSize3) </para>
/// <para> Метод создания массива double[] array = CreateArrayDouble </para>
/// <para> Метод создания одномерного массива bool[] array = CreateArrayBool(arrSize)</para>
/// <para> Метод заполнения одномерного массива случайными int элементами из диапазона от min до max - FillRandInt(arrName, 10, false, 100, true)</para>
/// <para> Метод заполнения массива трёхзначными числами и подсчёта чётных и нечётных FillRand3DigitIntCheckEvenOddCount(arrName, arrCount, true) </para>
/// <para> Метод заполнения трёхмерного массива двузначными неповторяющимися целыми числами из диапазона от 10 до 99 - FillRandInt3D</para>
/// <para> Метод заполнения двумерного массива случайными int элементами из диапазона от min до max - FillRandIntTwo(arrName, 10, false, 100, true) </para>
/// <para> Метод Заполнения одномерного массива случайными числами double - FillRandDouble(arrName, 10, 0, false, 500, 100, 4, true) </para>
/// <para> Метод заполнения двумерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac - FillRandDoubleTwo(arrName, 10, 0, false, 500, 100, 4, true)   </para>

/// <para> Метод печати массив ПЛОХОЙ </para>
/// <para> Метод печати массив !ПЛОХОЙ   </para>
/// <para> Метод печати двумерного массива !ПЛОХОЙ </para>
/// <para> Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt - IntervalCounter </para>
/// <para> Метод для ввода целочисленного значения Input</para>
/// <para> Метод вычисления размерности числа через Log: для 0...9 ->1; 10...99 ->2 и так далее </para>
/// <para> Метод поиска минимального элемента в двумерном массиве - MinInArray</para>
/// <para> Метод подбора преобразования основания системы счисления в подстрочный регистр. Например, 1302320341₅ = 15834855₁₀.</para>
/// <para> Метод создания одномерного массива float - CreateArrayFloat(arrSize) </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>
/// <para> Метод   </para>

/// </summary>
public static class MyLibrary123
{
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

    // Метод печати массив ПЛОХОЙ
    public static void PrintBad(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            WriteLine($"{array[i],3}");//Если придётся писать данные в файл или БД, то метод работать не будет
        }
        WriteLine();
    }

    // Метод подготовки для печати одномерного массива !ПЛОХОЙ
    /// <summary>
    /// Метод подготовки переменной типа string для печати. Элементы имеют размерность interval пунктов.
    /// </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// Пример вызова метода: PrintGood(arrName, 4)
    public static string PrintGood(int[] array, int interval)
    {
        string output = String.Empty; //Создали пустую строку
        int size = array.Length;

        for (int i = 0; i < size; i++)
        {
            output += $"{array[i]}{string.Concat(Enumerable.Repeat("\t", interval))}";
        }
        return output;
    }

    // Метод подготовки для печати двумерного массива !ПЛОХОЙ
    /// <summary>
    /// Метод подготовки переменной типа string для печати. Элементы имеют размерность interval пунктов.
    /// </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// Пример вызова метода: PrintGood(arrName, 4)
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

    // Метод подготовки для печати трёхмерного массива !ПЛОХОЙ
    /// <summary>
    /// Метод подготовки переменной типа string для печати. Элементы имеют размерность \t * interval пунктов.
    /// </summary>
    /// <param name="array">Массив, элементы которого нужно вывести на печать</param>
    /// <returns>Строка, заполненная элементами массива с интервалом interval пунктов</returns>
    /// Пример вызова метода: PrintGood(arrName, 4)
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

    // Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt
    /// <summary>
    /// Счётчик вхождения в массиве int элементов из диапазона от minInt до maxInt 
    /// <para>пример перевода строки</para>
    /// <para>пример перевода строки</para>
    /// </summary>
    /// <param name="array">Массив для проверки</param>
    /// <param name="minInt">Нижняя граница диапазона проверки</param>
    /// <param name="minInclude">Включается ли граничное значение в диапазон сравнения</param>
    /// <param name="maxInt">Верхняя граница диапазона проверки</param>
    /// <param name="maxInclude">Включается ли граничное значение в диапазон сравнения</param>
    /// <returns>Количество элементов в диапазоне от minInt до maxInt</returns>
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

    // Метод для ввода целочисленного значения
    /// <summary>
    /// Метод для ввода целочисленного значения 
    /// </summary>
    /// <param name="text">Текст пояснения для пользователя - что он должен ввести</param>
    /// <returns>Введенное пользователем значение</returns>
    public static int Input(string text)
    {
        Console.Write(text);
        return int.Parse(ReadLine());
    }

    //Метод вычисления размерности числа через Log: для 0...9 ->1; 10...99 ->2 и так далее
    /// <summary>
    /// Метод вычисления размерности числа через Log: для 0...9 ->1; 10...99 ->2 и так далее 
    /// </summary>
    /// <param name="number">Входное число типа int</param>
    /// <returns>Количество цифр во вкодном числе</returns>
    /// <example> digitsInNumber(15) возвращает 2 </example>
    public static int DigitsInNumber(int number)
    {
        return (int)Math.Log(number, 10) + 1;
    }

    // Метод удаления строки и столбца из двумерного массива
    /// <summary>
    /// Метод удаления строки и столбца из двумерного массива
    /// </summary>
    /// <param name="array">Массив, из которого удаляем строку и столбец</param>
    /// <param name="rowCol[0]">Номер исключаемой строки</param>
    /// <param name="rowCol[1]">Номер исключаемого столбца</param> 
    /// <param name="newArray">Новый массив с исключенными строкой и столбцом</param> 
    /// <param name="newdebugArray">Определяем режим отладки или прода. Если значение debug = <see langword="true"/>, то выводим специнфомацию</param> 
    /// <returns>Возвращаем уменьшенный массив</returns>
    /// Пример вызова метода: MiusMinArray(array, newArray, 5, 2)
    public static int[,] MiusMinArray(int[,] array, int[,] newArray, int[] rowCol, bool debug)
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
                if (debug) WriteLine($"i = {i}, j = {j}");
                newArray[i, j] = temp[i, j + 1];
            }
        }
        //4

        return newArray;
    }

    // Метод поиска минимального элемента в двумерном массиве
    /// <summary>
    /// Метод поиска минимального элемента в двумерном массиве
    /// </summary>
    /// <param name="array">Массив, в котором ищем элемент</param>
    /// <param name="rowCol[0]">Номер исключаемой строки</param>
    /// <param name="rowCol[1]">Номер исключаемого столбца</param> 
    /// Пример вызова метода: MinInArray(array, 5, 2)
    public static int[] MinInArray(int[,] array, int[] rowCol)
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
    /// <summary>
    /// Метод подбора правильного склонения для основания системы счисления. Например, 2 -> двоичной, 8 -> восьмеричной и т.д.
    /// </summary>
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

    // Метод преобразования входящего параметра в подстрочный или надстрочный регистр. Например, 1302320341₅ = 15834855₁₀.
    /// <summary>
    /// Метод преобразования входящего параметра в подстрочный или надстрочный регистр. Например, 1302320341₅ = 15834855₁₀.
    /// </summary>
    /// <param name="digit">Число, которое нужно перевести в подстрочный регистр</param>
    /// <param name="selector">Настройка режима 0 - нижний регистр, 1 - верхний регистр</param>
    /// <returns> Unicode символ типа char, соответствующий входящей цифре, в нужном регистре </returns>
    /// Пример вызова метода: MinInArray(5, 0)
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
    /// Пример вызова метода: MinInArray(5, 0)
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
    // Метод заполнения массива случайными целыми числами и подсчёта сумм чётных и нечётных элементов
    /// <summary>
    /// Метод заполнения одномерного массива случайными int элементами из диапазона от min до max
    /// </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <param name="count">Массив для вывода суммы чётных и нечётных элементов массива array</param> 
    /// Пример вызова метода: FillRandInt(arrName, 10, false, 100, true, count, DEBUG, intreval)
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

    // Метод заполнения массива случайными вещественными числами и подсчёта разницы max - min элементов
    /// <summary> Метод заполнения массива случайными вещественными числами и подсчёта разницы max - min элементов </summary>
    /// <param name="array">Массив, который заполняем</param>
    /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
    /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
    /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
    /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
    /// <param name="count">Массив для вывода min max элементов массива array</param> 
    /// Пример вызова метода: FillRandInt(arrName, 10, false, 100, true, counе, DEBUG, intreval)
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

    // Метод создания одномерного массива float
    /// <summary> Метод создания одномерного массива float </summary>
    /// <param name="count">Количество элементов нового int массива</param>
    /// <returns>Созданный массив из count элементов типа int</returns>
    /// <example>float[] arr = CreateArrayFloat(size1_0);
    public static float[] CreateArrayFloat(int count)
    {
        return new float[count];
    }
}