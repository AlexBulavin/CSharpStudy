//73. Фибоначчи Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

using static MyLibrary;
using static System.Console;
public class RecursionFibonacci
{
    public static uint depth = 0;//Глубина рекурсии
    public static void RecFibonacciMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 

        // Вводим числа а и в
        int a = Input("Введите первый элемент последовательности: ");
        int b = Input("Введите второй элемент последовательности: ");
        depth = 2; //Увеличиваем на 2, поскольку первые два элемента заданы пользователем
        int n = 2;
        while (n <= 2) n = Input("Введите количество элементов последовательности, которые \nнеобходимо вычислить. N должно быть больше 2: ");
        int[] results = CreateArrayInt(n);
        results[0] = a;
        results[1] = b;
        ChangeForegroundColor(4);

        //Выводим n -2 Fib(A, B) через рекурсию.
        Fib(a, b, n, depth, startTime, DEBUG, results);
        WriteLine($"\nЧисла Фибоначчи: {OutputArrByJoin(results, 1)}\n");
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
    }

    public static void Fib(int a, int b, int n, uint depth, DateTime requestTime, bool DEBUG, int[] results)
    {
        DateTime APowerBRecursionTime = DateTime.Now;
        depth++;
        int output = b + a;

        if (depth <= n)
        {
            a = b;
            b = output;
            results[depth - 1] = output;
            Fib(a, b, n, depth, requestTime, DEBUG, results);
            if (DEBUG)
            {
                ChangeForegroundColor(5);
                WriteLine($"n = {n}\tdepth = {depth}\t{APowerBRecursionTime.Hour.ToString()}:{APowerBRecursionTime.Minute.ToString()}:{APowerBRecursionTime.Second.ToString()}\t{APowerBRecursionTime - requestTime}");
                WriteLine($"a = {a}, b = {b}, output = {output}");
                ResetColor();
            }
        }
        ChangeForegroundColor(4);
    }
}