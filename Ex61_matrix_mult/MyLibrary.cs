using static System.Console;

/// <summary>
/// Это библиотека для работы с массивами
/// <para> Метод создания int массива - CreateArrayInt </para>
/// <para> Метод создания double массива - CreateArrayDouble </para>
/// <para> Метод создания bool массива - CreateArrayBool </para>
/// <para> Метод Заполнения массива случайными числами int - FillRandInt </para>
/// <para> Метод Заполнения массива случайными числами double - FillRandDouble </para>
/// </summary>
public static class MyLibrary123
{
  /// <summary>
  /// Метод создания одномерного массива int
  /// </summary>
  /// <param name="count">Количество элементов нового int массива</param>
  /// <returns>Созданный массив из count элементов типа int</returns>
  public static int[] CreateArrayInt(int count)
  {
    return new int[count]; // new int[count];
  }

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

  /// <summary>
  /// Метод создания массива double
  /// </summary>
  /// <param name="count">Количество элементов нового double массива</param>
  /// <returns>Созданный массив из count элементов типа double</returns>
  public static double[] CreateArrayDouble(int count)
  {
    return new double[count]; // new double[count];
  }

  /// <summary>
  /// Метод создания массива bool
  /// </summary>
  /// <param name="count">Количество элементов нового bool массива</param>
  /// <returns>Созданный массив из count элементов типа bool</returns>
  public static bool[] CreateArrayBool(int count)
  {
    return new bool[count]; // new bool[count];
  }

  /// <summary>
  /// Метод заполнения одномерного массива случайными int элементами из диапазона от min до max
  /// </summary>
  /// <param name="array">Массив, который заполняем</param>
  /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
  /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
  /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
  /// Пример вызова метода: FillRandInt(arrName, 10, false, 100, true)
  public static void FillRandInt(int[] array, int min, bool minInclude, int max, bool maxInclude)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(minInclude ? min : min + 1, maxInclude ? max : max - 1);
      //array[i] = new Random().Next(min, max);
    }
  }

  /// <summary>
  /// Метод заполнения двумерного массива случайными int элементами из диапазона от min до max
  /// </summary>
  /// <param name="array">Массив, который заполняем</param>
  /// <param name="min">Минимальное значение для заполнения случайными int элементами</param>
  /// <param name="minInclude">Включает ли минимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// <param name="max">Максиимальное значение для заполнения случайными int элементами</param>
  /// <param name="maxInclude">Включает ли максиимальное граничное значение в диапазон выбора для рандомайзера False - не включает, True - включает</param> 
  /// Пример вызова метода: FillRandInt(arrName, 10, false, 100, true)
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

  /// <summary>
  /// Метод заполнения одномерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac
  /// </summary>
  /// <param name="array">Массив, который заполняем</param>
  /// <param name="minInt">Минимальное значение целой части для заполнения случайными элементами</param>
  /// <param name="minFrac">Минимальное значение дробной части для заполнения случайными элементами</param>
  /// <param name="minInclude">Включает ли минимальное граничное значение minInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// <param name="maxInt">Максимальное значение целой части для заполнения случайными элементами</param>
  /// <param name="maxFrac">Максимальное значение дробной части для заполнения случайными элементами</param>
  /// <param name="numOfDigits">Разрядность дробной части для заполнения случайными элементами - показатель степени 10 - числа, на которое нужно делить рандомную часть 4 означает 10^4 = 10000</param> 
  /// <param name="maxInclude">Включает ли максиимальное граничное значение maxInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// Пример вызова метода: FillRandDouble(arrName, 10, 0, false, 500, 100, 4, true)

  public static void FillRandDouble(double[] array, int minInt, int minFrac, bool minInclude, int maxInt, int maxFrac, int numOfDigits, bool maxInclude)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next( minInclude ? minInt : minInt - 1, maxInclude ? maxInt : maxInt - 1) + (Random.Shared.Next( minFrac, maxFrac)/(Math.Pow(10, numOfDigits)));
      //array[i] = new Random().Next(min, max);
    }
  }
  
  /// <summary>
  /// Метод заполнения двумерного массива случайными double элементами из диапазона от minInt.minFrac до maxInt.maxFrac
  /// </summary>
  /// <param name="array">Массив, который заполняем</param>
  /// <param name="minInt">Минимальное значение целой части для заполнения случайными элементами</param>
  /// <param name="minFrac">Минимальное значение дробной части для заполнения случайными элементами</param>
  /// <param name="minInclude">Включает ли минимальное граничное значение minInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// <param name="maxInt">Максимальное значение целой части для заполнения случайными элементами</param>
  /// <param name="maxFrac">Максимальное значение дробной части для заполнения случайными элементами</param>
   /// <param name="numOfDigits">Разрядность дробной части для заполнения случайными элементами - показатель степени 10 - числа, на которое нужно делить рандомную часть 4 означает 10^4 = 10000</param> 
  /// <param name="maxInclude">Включает ли максиимальное граничное значение maxInt в диапазон выбора для рандомайзера False - не включает, True - включает</param>
  /// Пример вызова метода: FillRandDoubleTwo(arrName, 10, 0, false, 500, 100, 4, true)
  public static void FillRandDoubleTwo(double[,] array, int minInt, int minFrac, bool minInclude, int maxInt, int maxFrac, int numOfDigits, bool maxInclude)
  {
    int size0 = array.GetLength(0);
    int size1 = array.GetLength(1);
    for (int i = 0; i < size0; i++)
    {
      for (int j = 0; j < size1; j++)
      {
        array[i,j] = Random.Shared.Next( minInclude ? minInt : minInt - 1, maxInclude ? maxInt : maxInt - 1) + (Random.Shared.Next( minFrac, maxFrac)/(Math.Pow(10, numOfDigits)));
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
      WriteLine($"{array[i],3}");
    }
    WriteLine();
  }

  // Метод печати одномерного массива !ПЛОХОЙ
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
      output += $"{array[i], 3}";//$"{array[i], interval*""}"; //WriteLine($"{array[i],3}")
    }
    return output;
  }

  // Метод печати двумерного массива !ПЛОХОЙ
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
      for (int j = 0; j <size1; j++)
        output += $"{array[i, j], 3}";
      WriteLine();
    }
    return output;
  }

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

}