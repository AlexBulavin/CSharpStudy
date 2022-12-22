//74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита


using static MyLibrary;
using static System.Console;
public class WordsPermutation
{
    public static uint depth = 0;//Глубина рекурсии
    public static void RecursionPermutationMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        int n = 0;
        //Запрашиваем у пользователя длину слова n в диапазоне 1..4 для заданного набора символов
        while (n > 4 | n < 1)
        {
            n = Input("Введите длину слова n в диапазоне 1..4:");
        }
        // Создаём строку элементов из заданного набора символов
        string baseArr = "аисв";//{ 'а', 'и', 'с', 'в' };

        ChangeForegroundColor(4);

        //Выводим получившиеся "слова" через рекурсию.
        foreach (var letter in baseArr)
        {
            RecursionPermutationWords(baseArr, letter.ToString(), n, DEBUG);
        }
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
        WriteLine();
    }

    public static void RecursionPermutationWords(string baseArr, string w, int n, bool DEBUG)
    {
        if (DEBUG)
        {
            WriteLine($"DEBUG MODE baseArr = {baseArr}, w = {w}");
        }
        if (w.Length == n)
            Write($"{w}\t");
        else

            foreach (var letter in baseArr)
            {
                if (DEBUG)
                {
                    WriteLine($"DEBUG MODE letter = {letter}");
                }
                RecursionPermutationWords(baseArr, w + letter, n, DEBUG);
            }
    }
}