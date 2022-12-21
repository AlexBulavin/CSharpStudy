//73. Фибоначчи Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

using static MyLibrary;
using static System.Console;
public class RecursionFibonacci
{
    public static uint depth = 0;
    public static void RecFibonacciMain()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 
        //Фиксируем время
        DateTime startTime = DateTime.Now;

        // Вводим числа а и в
        int a = Input("Введите первый элемент последовательности: ");
        int b = Input("Введите второй элемент последовательности: ");
        int n = Input("Введите количество элементов последовательности, которые необходимо вычислить: ");
        ;
        ChangeForegroundColor(4);
        //Выводим n Fib(A, B) через рекурсию.
        WriteLine($"\nЭлемент {} = {Fib(n - 2, a, b, depth, startTime, DEBUG)}\n");
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
    }

    public static int Fib(int a, int b, int n, uint depth, DateTime requestTime, bool DEBUG)
    {
        DateTime APowerBRecursionTime = DateTime.Now;
        depth++;
        int output;
        if (DEBUG)
        {
            ChangeForegroundColor(5);
            WriteLine($"n = {n}\tDepth = {depth}\t{APowerBRecursionTime.Hour.ToString()}:{APowerBRecursionTime.Minute.ToString()}:{APowerBRecursionTime.Second.ToString()}\t{APowerBRecursionTime - requestTime}");
        }

        if (depth < n)
            output = b + a;
            a = b;
            b = output;
        Fib(a, b, n, depth, requestTime, DEBUG);


        ChangeForegroundColor(4);
        return output;
    }
}