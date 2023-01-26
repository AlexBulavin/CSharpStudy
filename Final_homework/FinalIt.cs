using static MyLibrary;
using static System.Console;
public class FinalIt
{
        //1. Запросить у пользователя размер массива N
        //2. Создать стартовый массив строк с рандомным заполнением символами
        // Вывести его на экран
        // Создать пустой финальный массив;
        //3. Проверить длину каждого элемента исходного массива. Если она меньше 3, сохранить элемент в финальном массиве
        //4. Вывести финальный массив в консоль.
    public static void FinalItMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 

        ChangeForegroundColor(4);

        int N = 0;
        //1. Запросить у пользователя размер массива N
        while (N <= 0)
            N = Input($"Задайте размер массива 0 < N: ");
        if (DEBUG) WriteLine($"selectDataGenerate = {N}");
        //2. Создать стартовый массив строк с рандомным заполнением символами
        string[] source_arr = CreateArrayString(N);
        FillRandString(source_arr, DEBUG);
        // Вывести его на экран
        WriteLine("Исходный массив:");
        WriteLine($"{OutputArrByJoin(source_arr, 1)}\n");
        // Создать пустой финальный массив;
        string[] final_arr = CreateArrayString(N);
        
        //3. Проверить длину каждого элемента исходного массива. Если она меньше 3, сохранить элемент в финальном массиве
        int j = 0;
        for (int i = 0; i < N; i++) 
        {
           if (source_arr[i].Length <= 3) 
           {
            final_arr[j] = source_arr[i];
            j++;
           }
        }
        //4. Вывести финальный массив в консоль.
        WriteLine("Финальный массив:");
        WriteLine(OutputArrByJoin(final_arr, 1));
    }
}